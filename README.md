## [NetflixClone project](https://nicotro.github.io/NetflixClone/)

**m2i FullStack developper training final project, developped in ReactJS and C#.**  
A 3 trainees team project to develop a Netflix like web-app (both front-end and back-end), mostly done on my own.  
Guidelines and basic documentation in the project [doc folder](/doc/).  
Project follow-up on [trello](https://trello.com/b/TuEfsah3/netflixclone).

- polished UI to replicate the Netflix look and feel,
- UI built with React & custom css, responsive design
- uses react-router-dom and axios dependencies for navigation and API communication,
- back-end / rest API developped in C# using the Entity framework,
- local SQL DB for data storage (no binaries, media pictures hosted on The Movie DataBase servers).

Currently functionnal, with:

- API support,
- token based user authentication,
- new user creation,
- DB stored FAQ display,
- basic media display by categories and genres.

Still missing:

- polished media display controls,
- video player in the media details part,
- administration front end for admin users,
- some endpoints and controllers for the admin part (user ban, media creation and update).

**Front built with React 18.2.0 - Back built with Microsoft .NET 6.0**  
[Try it here](https://nicotro.github.io/NetflixClone/)

![Front end preview](/NetflixClone_cover.png)

## Front Installation & usage

Use the npm package manager [npm](https://www.npmjs.com/) to install/update all the required dependencies

```bash
npm install
```

Run the app in dev mode

```bash
npm start
```
