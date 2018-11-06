Tech backlog:

*Get rid of deprecated PageFactory and Expected conditions (Selenium is moving away from those api due to their incapatibility with .net core/standard)

This is pointing at prod url by default can be switched to test by changing the value in App.config to Test
Must have chrome installed as this runs against chrome by default, other browsers currently not supported.
Running against test and local requires you to first launch angularjs.realworld.io locally
Follow instructions here: https://github.com/gothinkster/angularjs-realworld-example-app