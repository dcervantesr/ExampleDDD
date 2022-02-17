# Net Core C# base project with DDD and clean architecture #

## Folders ##
* apps => input projects (apis, consoles, webapps, etc)
* src => bounded contexts (domain, use cases, etc)
* tests => tests projects (unit tests, integration tests, etc)
------

## Bounded Context ##
### Tiendeo ###

-----
## Module ##
### Users ###
----
## Application layer ##
### Use cases ###
* CreateUserUseCase
* FindUserByIdUseCase
* GetAllUsersUseCase

### Dto ###
* CreateUserRequest
* UserDto
---
## Domain Layer ##
### Aggregate Root ###
* User
### Repository ###
* IUserRepository
### Value Objects ###
* UserId
* UserName
* UserMobile
### Services ###
* CreateUser
* FindUser
* GetAllUsers
### Exceptions ###
* UserAlreadyExistsException
* UserDoesNotExistException
* UserMobileInvalidException
* UserNameFieldRequiredException
* UserNameLengthExceededException
---
## Infrastructure Layer ##
* InMemoryUserRepository