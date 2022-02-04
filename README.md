# Web Api .Net 6

`https://api-itstep.azurewebsites.net/api/Product`

## Product schema
```
{
  "id": "int" (key),
  "title": "string", (require, maxLength(20))
  "description": "string", (require, maxLength(200), minLength(5))
  "price": "double", (require, range(1,10000))
  "available": "bool"
}
```
## CRUD

| Name  | Method  | Link  | 
| ------ | ------ | ------ |
| Get all | GET | ```https://api-itstep.azurewebsites.net/api/Product``` |
| Create | POST | ```https://api-itstep.azurewebsites.net/api/Product``` |
| Update | PUT | ```https://api-itstep.azurewebsites.net/api/Product``` |
| Delete | DELETE | ```https://api-itstep.azurewebsites.net/api/Product/?id={id}``` |
| Get by Id | GET | ```https://api-itstep.azurewebsites.net/api/Product/{id}``` |

