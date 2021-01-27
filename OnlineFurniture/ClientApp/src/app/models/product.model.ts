export interface ProductModelServer {
  id: number;
  name: string;
  category: string;
  description: string;
  image: string;
  price: number;
  quantity: number;
  images: string;
  url_image: string;
}


export interface ServerResponse  {
  count: number;
  products: ProductModelServer[];
}
