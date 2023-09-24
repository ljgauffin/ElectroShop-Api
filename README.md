# ElectroShop API

The ElectroShop API is a RESTful web service for managing an e-commerce platform called ElectroShop. This API allows you to perform various actions related to products, users, orders, and more.

## Table of Contents

- [Getting Started](#getting-started)
- [Endpoints](#endpoints)
- [Authentication](#authentication)
- [Pending Improvements](#pending-improvements)
- [Error Handling](#error-handling)
- [Usage Examples](#usage-examples)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

To get started with the ElectroShop API, follow these steps:

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/ljgauffin/ElectroShop-Api.git

2. Install the required dependencies:

   ```bash
    cd electroshop-api
    dotnet restore

3. Configure your database connection in the appsettings.json file.

4. Run the API:

   ```bash
    dotnet run

## Endpoints
The ElectroShop API provides the following endpoints:

* /api/products: Manage products (CRUD operations).
* /api/users: Manage user accounts.
* /api/orders: Manage orders and cart functionality.
* /api/auth: Authentication and token generation.
For detailed information about each endpoint and how to use them, please refer to the API documentation.

## Authentication
The API uses JWT (JSON Web Tokens) for authentication. To access protected endpoints, include the JWT token in the Authorization header of your requests.

Example header:

    Authorization: Bearer your_jwt_token_here

To obtain a JWT token, make a POST request to /api/auth/login with valid user credentials.

## Pending Improvements
* Completing CRUD of existing objects
* WhatsApp bot
* Database and CRUD expantion
* Logger
* Finish Swagger documentation

## Error Handling
The API returns detailed error messages in JSON format when errors occur. Be sure to check the status code and the message field in the response for error information.

Example error response:


    {
    "status": 400,
    "message": "Invalid input data."
    }
## Usage Examples
Here are some example use cases of the ElectroShop API:

Fetch a list of products.
Create a new user account.
Add products to a user's cart.
Place an order.
Authenticate and obtain a JWT token.
For code examples and detailed API documentation, please refer to the API Documentation.

## Contributing
We welcome contributions from the community! If you'd like to contribute to the ElectroShop API, please follow our Contributing Guidelines.

License
This project is licensed under the MIT License.





