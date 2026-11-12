import {Link,Routes,Route} from 'react-router-dom'
import { useEffect, useState } from 'react'

function Profile(){

  const [data, setData] = useState([]);

  useEffect(() => {
	fetch("localhost:3000/user.php")
		.then(response => data.response())
		.then(json => setData(json))
  });
  
  <ul> 
  {data.map((user) => ( <li key={user.Id}>{user.Login}{user.Role}</li> ))}
 	</ul> 

  if (data.Role  === "Admin")
  {
    return(
      <div>
        <h1>Личный кабинет</h1>
        <p>Добро пожаловать </p>
        <nav>
        <Link to ="/records">Мои записи</Link>
        {" "}
        <Link to ="/change-password">Смена пароля</Link>
        {" "}
        </nav>
        <p>Ваша библиотека</p>

    
      </div>
    )
  }
  if (data.Role === "User")
  {
    return(
      <div>
        <h1>Личный кабинет</h1>
        <p>Добро пожаловать </p>
        <nav>
        <Link to ="/records">Мои записи</Link>
        {" "}
        <Link to ="/change-password">Смена пароля</Link>
        </nav>
        <p>Ваша библиотека</p>
       
      </div>
    ) 
  }
  <Routes>
    <Route path ="/records" element ={<records/>}></Route>
    <Route path ="/change-password" element ={<change-password/>}></Route>
  </Routes>
  if (data.Role  === "Guest")
  {
    window.alert("Пользователь не найден пожалуйста зарегистрируйтесь или войдите в аккаунт");
  }
}
export default Profile;