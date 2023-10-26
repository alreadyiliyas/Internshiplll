import React, { Component } from 'react';

class GetUsers extends Component {
    constructor() {
        super();
        this.state = {
            users: []
        };
    }

    getUsers = async () => {
        try {
            const res = await fetch(
                'http://localhost:5000/api/users',
                {
                    method: 'get'
                }
            );
            const resJson = await res.json();
            this.setState({
                users: resJson
            });
        } catch (error) {
            console.error('Ошибка при получении данных:', error);
        }
    }

    render() {
        const users = this.state.users.map((item, index) => <li key={index}>{item.fName}</li>);
        return (
            <div className='App'>
                <button onClick={this.getUsers}>Загрузить список пользователей</button>
                <ul>{users}</ul>
            </div>
        );
    }
}

export default GetUsers;
