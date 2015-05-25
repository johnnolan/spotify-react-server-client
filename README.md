#Spotify Jukebox

This application is designed for a touchscreen interface so you can attach to a REST API for controlling a Spotify playlist.

###Overview

It uses Reactjs for the interface that connects to a simple rest api endpoint
that uses owin and [Redis](https://github.com/StackExchange/StackExchange.Redis).
This will handle all custom application logic such as queuing, upvoting etc.

Integration with the player and searching will use the
[Spotify Web Api](https://developer.spotify.com/web-api/).

###Features

* Searching
* Queuing
* Upvoting
* Saved song play history to create into a playlist after the event
* Move song to top override
