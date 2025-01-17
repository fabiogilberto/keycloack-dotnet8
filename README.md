# keycloack-dotnet8

A simple Keycloak, Postgres and a Dotnet 8 api integration
## Run Locally

Clone the project

```bash
  git clone https://github.com/fabiogilberto/keycloack-dotnet8.git
```

Go to the project directory

```bash
  cd keycloack-dotnet8
```

Change configurations

```bash
  Update configurations on docker-compose.override.yml
```

Start containers

```bash
  docker-compose up -d
```


## API Reference

#### authenticated user name and roles

```http
  GET /users
```

#### authenticated user name and roles

```http
  GET /users/adm
```

| Description                |
| :------------------------- |
| **Required** Bearer token with adm role | 


## Authors

- [@fabiogilberto](https://github.com/fabiogilberto)

