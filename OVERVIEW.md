### How is the codebase organised?

The main project is `Sniper`.

The namespaces are organised so that the relevant components are easy to discover:

 - **Authentication** - everything related to authenticating requests
 - **Clients** - the logic for interacting with various parts of the GitHub API
 - **Exceptions** - types which represent exceptional behaviour from the API
 - **Helpers** - assorted extensions and helpers to keep the code neat and tidy
 - **Http** - the internal networking components which Sniper requires
 - **Models** - types which represent request/response objects

Unless you're modifying some core behaviour, the **Clients** and **Models** namespaces
are likely to be the most interesting areas.


