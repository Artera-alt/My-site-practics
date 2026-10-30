function Login()
{
    return(
<form action="" method="get" class="form-example">
  <h1>Вход в аккаунт</h1>
  <div class="form-example">
    <label for="name">Login: </label>
    <input type="text" name="name" id="name" required />
  </div>
  <div class="form-example">
    <label for="name">Password: </label>
    <input type="password" name="password" id="password" required />
  </div>
  <div class="form-example">
    <input type="submit" value="Войти" />
  </div>
</form>
);
}
export default Login;