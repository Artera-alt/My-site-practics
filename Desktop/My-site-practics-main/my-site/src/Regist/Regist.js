
function Regist()
{
  return(
<form action="" method="get" class="form-example">
  <h1>Регистрация</h1>
  <div class="form-example">
    <label for="name">login: </label>
    <input type="text" name="name" id="name" required />
  </div>
  <div class="form-example">
    <label for="name">Password: </label>
    <input type="password" name="password" id="password" required />
  </div>
  <div class="form-example">
    <label for="email">email: </label>
    <input type="email" name="email" id="email" required />
  </div>
  <div class="form-example">
    <input type="submit" value="зарегистрироваться" />
  </div>
</form>
  );
}
export default Regist;