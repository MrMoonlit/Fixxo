import "./App.css"
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Home from './Components/views/Home';
import ProductDetails from './Components/views/ProductDetails';
import Contacts from './Components/views/Contacts';

function App() {
  return (<>
  <BrowserRouter>
  <Routes>
    <Route path="/" element={<Home/>}/>
    <Route path="/products" element={<ProductDetails/>}/>
    <Route path="/contacts" element={<Contacts/>}/>
  </Routes>
  
  </BrowserRouter>
  </>);
}

export default App;
