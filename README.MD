# Introduction
Demo project showcasing Redis behaviour with .NET 6

---

### Dependencies
[StackExchange.Redis](https://stackexchange.github.io/StackExchange.Redis/)

---

### What is Redis?
Redis is a high performance in-memory storage, that allows to store data as key-value pairs.
Redis can also act as a pub/sub agent, but it's out of this demo project scope

---

### Where can it be usefull?
Imagine, in your software, there is any page where you need to load data, where some of it, need's to be fetched from the database.
But, that data, also doesn't change at every second. So, why not cache it during an interval of time, so that you can reduce the amount of database queries?
Other scenario, is, imagin you have integrated a third party API, and that API also has a daily limit of API calls, you can cache the API calls, so that you can prevent your system of being locked out of the API.

---

### How does it work?
It's actually very simple, Redis stores data in the form of Key-Value pairs, like a regular Dictionary, where you use the key as the Identifier of the value.
To fetch the cached data, normally, you just provide the key that references that data.
The data, is stored inside the computer memory(RAM), during a locked period of time

---

### Requirements
- Docker
- Docker Desktop(not required)
- .NET
- Visual Studio(or any other type of IDE)

---

### Setup

#### Run image
```docker run --name demo-redis-service -p 6379:6379 -d redis```

#### Redis connection

```appsettings.json```

```json
{
  ...
  "RedisConnection": "localhost"
}
```
Set the value for ```RedisConnection```

### Output
Setting cache
![Caching data](/prtscrns/set_cache.png)

Retrieving cache
![Retrieving cached data](/prtscrns/get_cache.png)

----

### References
[StackExchange docs](https://github.com/StackExchange/StackExchange.Redis)

[StackExchange Github](https://stackexchange.github.io/StackExchange.Redis/)