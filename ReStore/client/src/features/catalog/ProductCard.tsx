import {
  List,
  ListItem,
  ListItemAvatar,
  Avatar,
  ListItemIcon,
} from "@mui/material";
import { Product } from "../../app/models/product";
interface Props {
  product: Product;
}
export default function ProductCard({ product }: Props) {
  return (
    <List>
      <ListItem key={product.name}>
        <ListItemAvatar>
          <Avatar src={product.pictureUrl} />
        </ListItemAvatar>
        <ListItemIcon>
          {product.name} - {product.price}
        </ListItemIcon>
      </ListItem>
    </List>
  );
}
