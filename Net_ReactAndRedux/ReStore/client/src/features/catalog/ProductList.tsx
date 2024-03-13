import { List } from "@mui/material";
import { Product } from "../../app/models/product";
import ProductCard from "./ProductCard";

interface Props {
    products: Product[];
}

export default function ProductList(props: Props) {
    return (
        <List>
            {props.products.map(product => (
                <ProductCard key={product.id} product={product}></ProductCard>
            ))}
        </List>
    )
}