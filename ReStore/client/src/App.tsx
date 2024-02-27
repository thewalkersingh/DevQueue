import { useEffect, useState } from "react";

function App() {
  const [products, setProducts] = useState([
    { name: "product 1", price: 100.0 },
    { name: "product 2", price: 400.0 },
  ]);
  useEffect(() => {
    fetch("http://localhost:5000/api/products")
      .then((response) => response.json())
      .then((data) => setProducts(data));
  }, []);
  function addProducts() {
    setProducts((prevState) => [
      ...products,
      {
        name: "product " + (prevState.length + 1),
        price: prevState.length * 100 + 100,
      },
    ]);
  }
  return (
    <div className="app">
      <h1>Re-Store</h1>
      <ul>
        {products.map((item) => (
          <li key={item.name}>
            {item.name} = {item.price}
          </li>
        ))}
      </ul>
      <button onClick={addProducts}>Add Product</button>
    </div>
  );
}
export default App;
