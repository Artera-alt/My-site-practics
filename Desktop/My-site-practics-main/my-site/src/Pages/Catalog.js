import {useEffect,useState} from 'react'
function Catalog() {
  const [data,setData] = useState([]);
  useEffect(()=>{
    fetch("http://Localhost:80/game.php")
    .then(response =>response.json())
    .then(json => setData(json))
  })
  return (
    <ul>
      {data.map(game => <li key={game.id}>{game.Name}  {game.Price}  {game.Weight}  {game.Release_Date}</li>)}
    </ul>
  );
}

export default Catalog;