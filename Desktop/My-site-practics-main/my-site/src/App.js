import {Link,Routes,Route} from 'react-router-dom'
import './App.css';
import About from './Pages/About';
import Contacs from './Pages/Contacs';
import Catalog from './Pages/Catalog';
import Workforce from './Pages/Workforce';
import Home from './Pages/HomePage';
import Regist from './Regist/Regist';
import Login from './Regist/Login';

function App() {
  return (
    <div>
      <nav>
        <Link to ="/about">О нас</Link>
        {" "}
        <Link to ="/Contacs">Связь</Link>
        {" "}
        <Link to ="/Catalog">Каталог</Link>
        {" "}
        <Link to ="/Workforce">Сотрудники</Link>
      </nav>
      <Routes>
        <Route path="/" element={<Home />} /> 
        <Route path ="/about" element ={<About/>}></Route>
        <Route path ="/Contacs" element ={<Contacs/>}></Route>
        <Route path ="/Catalog" element ={<Catalog/>}></Route>
        <Route path ="/Workforce" element ={<Workforce/>}></Route>
        <Route path ='/regist' element ={<Regist/>}></Route>
        <Route path ='/Login' element ={<Login/>}></Route>
      </Routes>
      <Link to ="/regist">Зарегистрироваться</Link>
      {" "}
      <Link to ="/Login">Войти в аккаунт</Link>
    <footer>
      © 2026 GameforGamers
    </footer>
    </div>
    
  );
}

export default App;