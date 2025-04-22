# Blog API

A simple API for managing blog posts and comments using **.NET Core** and **MongoDB**, running inside Docker containers.

## Technologies

- **.NET Core** for the API
- **MongoDB** for the database
- **Docker** for containerization
## Prerequisites

Before starting the project, ensure that the following tools are installed on your machine:

- **Docker**: To run the application and MongoDB in containers. [Install Docker](https://www.docker.com/get-started)
- **Visual Studio Code (optional)**: A lightweight code editor with Docker support.

## Setup

### 1. Clone the Repository

Clone the repository to your local machine:
```bash
git clone https://github.com/your-username/blog-api.git](https://github.com/leviisac/BlogApi.git
```
### 2. Run the api

Ensure Docker is running on your machine and you have Docker Compose available.

Build and Run the Containers
Run the following Docker Compose command to build the images and start the containers:

```bash
docker-compose up --build
```

### 3. Access the api
Access the API:
http://localhost:5010/swagger/index.html


If I had more time available, here are some improvements I would make:

### 1. Validation
Implement validation for inputs to ensure all necessary fields are provided, and add error handling for invalid requests.

### 2. Testing
Add unit tests for the services to ensure the code is thoroughly tested and production-ready.

### 3. Caching
Implement caching mechanisms (e.g., Redis) to improve API performance, especially for frequently accessed data like blog posts and comments.

### 4. Authentication
 Add authentication and authorization, such as JWT, to protect sensitive endpoints

 
