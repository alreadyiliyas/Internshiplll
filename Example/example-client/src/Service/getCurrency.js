import React, {Component} from 'react';

class GetCurrency extends Component {
    constructor() {
        super();
        this.state = {
            currencies: [],
            selectedCurrency: '',
        };
    }

    sendCurrencyToServer = async (selectedCurrency) => {
        try {
            const res = await fetch(
                'http://localhost:5000/api/currency/exchangeRate',
                {
                    method: 'post',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({ selectedCurrency }),
                }
            );
            const resJson = await res.json();
            this.setState({
                currencies: resJson,
            });
        } catch (error) {
            console.error('Ошибка при получении данных:', error);
        }
    }

    handleCurrencyChange = (event) => {
        const selectedCurrency = event.target.value;
        this.sendCurrencyToServer(selectedCurrency);
        this.setState({ selectedCurrency });
    }

    render() {
        const { currencies, selectedCurrency } = this.state;
        return (
            <div>
                <select onChange={this.handleCurrencyChange} value={selectedCurrency}>
                    <option value="USD">Доллар</option>
                    <option value="RUB">Рубль</option>
                    <option value="EUR">Еуро</option>
                    <option value="AED">Арабский кувейт</option>
                    <option value="INR">Индийский рупий</option>
                </select>
                <div>
                    {currencies.map((currency, index) => (
                        <div key={index}>
                            <span>Название: {currency.value}</span>
                            <span>Код: {currency.data.code}</span>
                        </div>
                    ))}
                </div>
            </div>
        );
    }
};

export default GetCurrency;