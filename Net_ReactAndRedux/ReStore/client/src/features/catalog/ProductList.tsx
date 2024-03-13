import { Grid } from "@mui/material";
import { Product } from "../../app/models/product";
import ProductCard from "./ProductCard";

interface Props {
    products: Product[];
}

export default function ProductList(props: Props) {
    return (
        <Grid container spacing={2}>
            {props.products.map(product => (
                <Grid item xs={3} key={product.id}>
                    <ProductCard product={product}></ProductCard>
                </Grid>
            ))}
        </Grid>
    )
}