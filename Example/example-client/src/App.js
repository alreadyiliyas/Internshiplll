import {Component} from "react";


class App extends Component {
  constructor() {
    super();
    this.state = {
      users: []
    }
  }

  getUsers = async () => {
    var res = await fetch(
       'http://localhost:5000/api/users',
        {
          method: 'get'
        }
    )

    var resJson = await res.json();
    this.setState({
      users: resJson
    })
  }
  render() {
    const users = this.state.users.map((item, index) => <li key={index}>{item.FName}</li>)
    return (
        <div className='App'>
          <button onClick={this.getUsers}>Загрузить список пользователей</button>
          <ul>{users}</ul>
        </div>
    )
  }
}



export default App;
