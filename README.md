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
cd blog-api
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
