#Spotify Jukebox

This application is designed for a touchscreen interface so you can attach to a REST API for controlling a Spotify playlist.

###Overview

It uses Reactjs for the interface that connects to a simple rest api endpoint.

The endpoint will use owin and a .net spotify api library.
* [https://github.com/JohnnyCrazy/SpotifyAPI-NET](https://github.com/JohnnyCrazy/SpotifyAPI-NET)
* [https://github.com/Alxandr/SpotiFire](https://github.com/Alxandr/SpotiFire)

[Redis](https://github.com/StackExchange/StackExchange.Redis) is used for storing playlist information and data for the client.

###Features

* Searching
* Queuing
* Upvoting
* Saved song play history to create into a playlist after the event
* Move song to top override
