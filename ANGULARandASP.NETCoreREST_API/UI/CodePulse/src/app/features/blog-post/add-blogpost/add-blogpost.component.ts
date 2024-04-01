import { Component, OnDestroy, OnInit } from '@angular/core';
import { AddBlogPost } from '../models/add-blog-post.model';
import { BlogPostService } from '../services/blog-post.service';
import { Router } from '@angular/router';
import { Observable, Subscription } from 'rxjs';
import { CategoryService } from '../../category/services/category.service';
import { Category } from '../../category/models/category.model';
import { ImageService } from 'src/app/shared/components/image-selector/image.service';

@Component({
  selector: 'app-add-blogpost',
  templateUrl: './add-blogpost.component.html',
  styleUrls: ['./add-blogpost.component.css']
})
export class AddBlogpostComponent implements OnInit, OnDestroy {
  model: AddBlogPost;
  isImageSelectorVisible: boolean = false;
  categories$?: Observable<Category[]>;
  imageSelectorSubscription?: Subscription;
  private addBlogPostSubscription?: Subscription;
  
  constructor(private blogPostService: BlogPostService,
    private router: Router,
    private categoryService: CategoryService,
    private imageService: ImageService) {
    this.model = {
      title: '',
      shortDescription: '',
      content: '',
      featuredImageUrl: '',
      urlHandle: '',
      author: '',
      publishedDate: new Date(),
      isVisible: true,
      categories: []
    };
  }

  onFormSubmit(): void {
    this.addBlogPostSubscription = this.blogPostService.createBlogPost(this.model)
      .subscribe({
        next: (response) => {
          this.router.navigateByUrl('/admin/blogposts');
        }
      });
  }
  openImageSelector(): void {
    this.isImageSelectorVisible = true;
  }

  closeImageSelector(): void {
    this.isImageSelectorVisible = false;
  }
  ngOnInit(): void {
    this.categories$ = this.categoryService.getAllCategories();
    this.imageSelectorSubscription = this.imageService.onSelectImage()
      .subscribe({
        next: (selectImage) => {
          this.model.featuredImageUrl = selectImage.url;
          this.closeImageSelector();
        }
      });
  }
  ngOnDestroy(): void {
    this.addBlogPostSubscription?.unsubscribe();
    this.imageSelectorSubscription?.unsubscribe();
  }
}

