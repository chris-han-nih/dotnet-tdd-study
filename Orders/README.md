Shop platform
---

### Initialize database
```bash
$ docker run --name postgres -e POSTGRES_PASSWORD=1234qwer -p 5432:5432 -d postgres
```

### Create migration
```bash
$ donet ef migrations add InitialCreate
```

### Update database
```bash
$ donet ef database update
```
