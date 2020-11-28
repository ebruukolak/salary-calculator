# Introduction

This project provides dummy data for employees' salary based on different employee salary calculations.

## Prerequisites

Docker should be installed on your machine.

## How to run

On terminal, go into project directory.



```bash
docker-compose build
```
for the initialization, this command builds docker container on your machine. It may take some minutes.

```bash
docker run -p 5000:80 salarycalculation
```
this command will run docker container. From now on you can reach dummy data via  
```http://localhost:5000/employee/GetEmployees```

