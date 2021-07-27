import React, { Component } from 'react'
import "./Account.css";
import { GET_ALL_ACCOUNT} from '../../HTTPServer/httpAccount.js';

export default class Account extends Component {
	constructor(props) {
		super(props);
		this.state = {
			accountList: [],
		}
	}

	componentDidMount() {
		GET_ALL_ACCOUNT('Index')
			.then(response => {
				this.setState({ accountList: response.data });
			});
	}

	render() {
		return (
			<div>
				<div className="admin__heading">
					<h1 className="customers__title">Customers</h1>
				</div>
				<div className="admin__body">
					<table className="customers-table">
						<thead>
							<tr className="customers-table__title">
								<th className="customers-table__title--th customers__id">Id</th>
								<th className="customers-table__title--th customers__username">Username</th>
								<th className="customers-table__title--th customers__password">Password</th>
								<th className="customers-table__title--th customers__fullname">Full Name</th>
								<th className="customers-table__title--th customers__phone">Phone Number</th>
							</tr>
						</thead>
						<tbody>
							{
								this.state.accountList.map((account) => (
									<tr className="customers-table__data" key={account.id}>
										<td className="customers-table__data--td text--center">{account.id}</td>
										<td className="customers-table__data--td">{account.userName}</td>
										<td className="customers-table__data--td">{account.password}</td>
										<td className="customers-table__data--td">{account.fullName}</td>
										<td className="customers-table__data--td text--center">{account.phoneNumber}</td>
									</tr>
								))
							}
						</tbody>
					</table>
				</div>
			</div>
		)
	}
}
