import { Component, OnDestroy } from '@angular/core';
import { AddCategoryRequest } from '../models/add-category-request.model';
import { CategoryService } from '../services/category.service';
import { Subscription } from 'rxjs/internal/Subscription';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnDestroy {
  // lấy dữ liệu từ template
  model: AddCategoryRequest;
  //quản lý việc đăng ký và hủy đăng kí với Observables, tránh rò rỉ bộ nhớ
  private addCategorySubscriprion?: Subscription;
  constructor(private categoryService: CategoryService,
    private router: Router) {
    this.model = {
      name: '',
      urlHandle: ''
    };
  }
  ;
  onFormSubmit() {
    this.addCategorySubscriprion = this.categoryService.addCategory(this.model)
      .subscribe( //xử lý khi thành công, chuyển hướng người dùng đến trang admin/categories
        {
          next: (response) => {
            this.router.navigateByUrl('/admin/categories');
          }
        }
      );
  }
  // hủy đăng kí khi component được đăng kí trong onFormSubmit, để tránh rò rỉ bộ nhớ
  // vì nếu không hủy callback tỏng subscribe sẽ vẫn tồn tại và có thể được gọi sau khi component bị hủy
  ngOnDestroy(): void {
    this.addCategorySubscriprion?.unsubscribe();
  }
}

