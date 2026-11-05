import {Link,Routes,Route} from 'react-router-dom'


const fetchUserProfile = async () => {
    const res = await fetch('http://Localhost:80/user.php');
    return res.json(); 
};

const fetch = async () => {
    const res = await fetch('http://Localhost:80/owngameuser.php');
    return res.json(); 
};

function Profile() {
  const { data: Login, isLoading  } = useQuery({
    queryKey: ['userProfile'],
    queryFn: fetchUserProfile,
    
   select: (user) => ({ login: user.Login, role: user.Role })
  });

  if (isLoading) return <div>Загрузка...</div>;
  const { login, role } = data;
  if (role === "Admin")
  {
    return(
      <div>
        <h1>Личный кабинет</h1>
        <p>Добро пожаловать {login}</p>
        <p>Ваша библиотека</p>
        {data.map(owngameuser => <li key={owngameuser.id}>{owngameuser.Game_Name}</li>)}
        <nav>

        </nav>
      </div>
    )
  }
  if (role === "User")
  {
    return(
      <div>
        <h1>Личный кабинет</h1>
        <p>Добро пожаловать {login}</p>
        <p>Ваша библиотека</p>
        {data.map(owngameuser => <li key={owngameuser.id}>{owngameuser.Game_Name}</li>)}
      </div>
    )
  }
  if (role === "Guest")
  {
    window.alert("Пользователь не найден пожалуйста зарегистрируйтесь или войдите в аккаунт");
  }
}

export default Profile;