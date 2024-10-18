# keycloack-dotnet8

A simple Keycloak, Postgres and a Dotnet api integration
## Run Locally

Clone the project

```bash
  git clone https://github.com/fabiogilberto/keycloack-dotnet8.git
```

Go to the project directory

```bash
  cd keycloack-dotnet8
```

Start containers

```bash
  docker-compose up -d
```


## API Reference

#### Get all items

```http
  GET /users
```

| Description                |
| :------------------------- |
| Returns authenticated user name and roles |

```http
  GET /users/adm
```

| Description                |
| :------------------------- |
| Returns authenticated user name and roles | 
| **Required** Bearer token with adm role | 


## Authors

- [@fabiogilberto](https://github.com/fabiogilberto)

