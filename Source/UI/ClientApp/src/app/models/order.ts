import { Tree } from "./tree";

export interface Order {
  tree: Tree;
  deliveryAddress: string;
  deliveryDate: string;
}

export interface OrderRequest {
  treeName: string;
  treeType: number;
  deliveryAddress: string;
}
