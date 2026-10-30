const fetchUserProfile = async () => {
    const res = await fetch('http://Localhost:80/user.php');
    return res.json(); 
};
function Profile() {
  const { data: Login, isLoading  } = useQuery({
    queryKey: ['userProfile'],
    queryFn: fetchUserProfile,
    
   select: (user) => ({ login: user.Login, role: user.Role })
  });
  if (isLoading) return <div>Загрузка...</div>;
  if (Role == "Admin")
  {
    return
  }
  if (Role == "User")
  {

  }
  if (Role == "Guest")
  {
    
  }
  return(

  )
}


export default Profile;
