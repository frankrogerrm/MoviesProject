using MovieProject.Service.Models;

namespace MovieProject.Service.Data
{
    public static class TestData
    {
        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie
            {
                Id = 1,
                Title = "Beetlejuice",
                Year = 1988,
                Runtime = 92,
                Genres = "Comedy,Fantasy",
                Directors = "Tim Burton",
                Actors = "Alec Baldwin, Geena Davis, Annie McEnroe, Maurice Page",
                Plot =
                    "A couple of recently deceased ghosts contract the services of a 'bio-exorcist' in order to remove the obnoxious new owners of their house.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTUwODE3MDE0MV5BMl5BanBnXkFtZTgwNTk1MjI4MzE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 2,
                Title = "The Cotton Club",
                Year = 1984,
                Runtime = 127,
                Genres = "Crime,Drama,Music",
                Directors = "Francis Ford Coppola",
                Actors = "Richard Gere, Gregory Hines, Diane Lane, Lonette McKee",
                Plot =
                    "The Cotton Club was a famous night club in Harlem. The story follows the people that visited the club, those that ran it, and is peppered with the Jazz music that made it so famous.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU5ODAyNzA4OV5BMl5BanBnXkFtZTcwNzYwNTIzNA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 3,
                Title = "The Shawshank Redemption",
                Year = 1994,
                Runtime = 142,
                Genres = "Crime,Drama",
                Directors = "Frank Darabont",
                Actors = "Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler",
                Plot =
                    "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BODU4MjU4NjIwNl5BMl5BanBnXkFtZTgwMDU2MjEyMDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 4,
                Title = "Crocodile Dundee",
                Year = 1986,
                Runtime = 97,
                Genres = "Adventure,Comedy",
                Directors = "Peter Faiman",
                Actors = "Paul Hogan, Linda Kozlowski, John Meillon, David Gulpilil",
                Plot =
                    "An American reporter goes to the Australian outback to meet an eccentric crocodile poacher and invites him to New York City.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTg0MTU1MTg4NF5BMl5BanBnXkFtZTgwMDgzNzYxMTE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 5,
                Title = "Valkyrie",
                Year = 2008,
                Runtime = 121,
                Genres = "Drama,History,Thriller",
                Directors = "Bryan Singer",
                Actors = "Tom Cruise, Kenneth Branagh, Bill Nighy, Tom Wilkinson",
                Plot =
                    "A dramatization of the 20 July assassination and political coup plot by desperate renegade German Army officers against Hitler during World War II.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTg3Njc2ODEyN15BMl5BanBnXkFtZTcwNTAwMzc3NA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 6,
                Title = "Ratatouille",
                Year = 2007,
                Runtime = 111,
                Genres = "Animation,Comedy,Family",
                Directors = "Brad Bird, Jan Pinkava",
                Actors = "Patton Oswalt, Ian Holm, Lou Romano, Brian Dennehy",
                Plot =
                    "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous restaurant.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTMzODU0NTkxMF5BMl5BanBnXkFtZTcwMjQ4MzMzMw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 7,
                Title = "City of God",
                Year = 2002,
                Runtime = 130,
                Genres = "Crime,Drama",
                Directors = "Fernando Meirelles, Kátia Lund",
                Actors = "Alexandre Rodrigues, Leandro Firmino, Phellipe Haagensen, Douglas Silva",
                Plot =
                    "Two boys growing up in a violent neighborhood of Rio de Janeiro take different paths= one becomes a photographer, the other a drug dealer.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA4ODQ3ODkzNV5BMl5BanBnXkFtZTYwOTc4NDI3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 8,
                Title = "Memento",
                Year = 2000,
                Runtime = 113,
                Genres = "Mystery,Thriller",
                Directors = "Christopher Nolan",
                Actors = "Guy Pearce, Carrie-Anne Moss, Joe Pantoliano, Mark Boone Junior",
                Plot =
                    "A man juggles searching for his wife's murderer and keeping his short-term memory loss from being an obstacle.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNThiYjM3MzktMDg3Yy00ZWQ3LTk3YWEtN2M0YmNmNWEwYTE3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 9,
                Title = "The Intouchables",
                Year = 2011,
                Runtime = 112,
                Genres = "Biography,Comedy,Drama",
                Directors = "Olivier Nakache, Eric Toledano",
                Actors = "François Cluzet, Omar Sy, Anne Le Ny, Audrey Fleurot",
                Plot =
                    "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTYxNDA3MDQwNl5BMl5BanBnXkFtZTcwNTU4Mzc1Nw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 10,
                Title = "Stardust",
                Year = 2007,
                Runtime = 127,
                Genres = "Adventure,Family,Fantasy",
                Directors = "Matthew Vaughn",
                Actors = "Ian McKellen, Bimbo Hart, Alastair MacIntosh, David Kelly",
                Plot =
                    "In a countryside town bordering on a magical land, a young man makes a promise to his beloved that he'll retrieve a fallen star by venturing into the magical realm.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjkyMTE1OTYwNF5BMl5BanBnXkFtZTcwMDIxODYzMw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 11,
                Title = "Apocalypto",
                Year = 2006,
                Runtime = 139,
                Genres = "Action,Adventure,Drama",
                Directors = "Mel Gibson",
                Actors = "Rudy Youngblood, Dalia Hernández, Jonathan Brewer, Morris Birdyellowhead",
                Plot =
                    "As the Mayan kingdom faces its decline, the rulers insist the key to prosperity is to build more temples and offer human sacrifices. Jaguar Paw, a young man captured for sacrifice, flees to avoid his fate.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNTM1NjYyNTY5OV5BMl5BanBnXkFtZTcwMjgwNTMzMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 12,
                Title = "Taxi Driver",
                Year = 1976,
                Runtime = 113,
                Genres = "Crime,Drama",
                Directors = "Martin Scorsese",
                Actors = "Diahnne Abbott, Frank Adu, Victor Argo, Gino Ardito",
                Plot =
                    "A mentally unstable Vietnam War veteran works as a night-time taxi driver in New York City where the perceived decadence and sleaze feeds his urge for violent action, attempting to save a preadolescent prostitute in the process.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNGQxNDgzZWQtZTNjNi00M2RkLWExZmEtNmE1NjEyZDEwMzA5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 13,
                Title = "No Country for Old Men",
                Year = 2007,
                Runtime = 122,
                Genres = "Crime,Drama,Thriller",
                Directors = "Ethan Coen, Joel Coen",
                Actors = "Tommy Lee Jones, Javier Bardem, Josh Brolin, Woody Harrelson",
                Plot =
                    "Violence and mayhem ensue after a hunter stumbles upon a drug deal gone wrong and more than two million dollars in cash near the Rio Grande.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA5Njk3MjM4OV5BMl5BanBnXkFtZTcwMTc5MTE1MQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 14,
                Title = "Planet 51",
                Year = 2009,
                Runtime = 91,
                Genres = "Animation,Adventure,Comedy",
                Directors = "Jorge Blanco, Javier Abad, Marcos Martínez",
                Actors = "Jessica Biel, John Cleese, Gary Oldman, Dwayne Johnson",
                Plot =
                    "An alien civilization is invaded by Astronaut Chuck Baker, who believes that the planet was uninhabited. Wanted by the military, Baker must get back to his ship before it goes into orbit without him.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTUyOTAyNTA5Ml5BMl5BanBnXkFtZTcwODU2OTM0Mg@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 15,
                Title = "Looper",
                Year = 2012,
                Runtime = 119,
                Genres = "Action,Crime,Drama",
                Directors = "Rian Johnson",
                Actors = "Joseph Gordon-Levitt, Bruce Willis, Emily Blunt, Paul Dano",
                Plot =
                    "In 2074, when the mob wants to get rid of someone, the target is sent into the past, where a hired gun awaits - someone like Joe - who one day learns the mob wants to 'close the loop' by sending back Joe's future self for assassination.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTY3NTY0MjEwNV5BMl5BanBnXkFtZTcwNTE3NDA1OA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 16,
                Title = "Corpse Bride",
                Year = 2005,
                Runtime = 77,
                Genres = "Animation,Drama,Family",
                Directors = "Tim Burton, Mike Johnson",
                Actors = "Johnny Depp, Helena Bonham Carter, Emily Watson, Tracey Ullman",
                Plot =
                    "When a shy groom practices his wedding vows in the inadvertent presence of a deceased young woman, she rises from the grave assuming he has married her.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTk1MTY1NjU4MF5BMl5BanBnXkFtZTcwNjIzMTEzMw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 17,
                Title = "The Third Man",
                Year = 1949,
                Runtime = 93,
                Genres = "Film-Noir,Mystery,Thriller",
                Directors = "Carol Reed",
                Actors = "Joseph Cotten, Alida Valli, Orson Welles, Trevor Howard",
                Plot =
                    "Pulp novelist Holly Martins travels to shadowy, postwar Vienna, only to find himself investigating the mysterious death of an old friend, Harry Lime.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjMwNzMzMTQ0Ml5BMl5BanBnXkFtZTgwNjExMzUwNjE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 18,
                Title = "The Beach",
                Year = 2000,
                Runtime = 119,
                Genres = "Adventure,Drama,Romance",
                Directors = "Danny Boyle",
                Actors =
                    "Leonardo DiCaprio, Daniel York, Patcharawan Patarakijjanon, Virginie Ledoyen",
                Plot =
                    "Twenty-something Richard travels to Thailand and finds himself in possession of a strange map. Rumours state that it leads to a solitary beach paradise, a tropical bliss - excited and intrigued, he sets out to find it.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BN2ViYTFiZmUtOTIxZi00YzIxLWEyMzUtYjQwZGNjMjNhY2IwXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 19,
                Title = "Scarface",
                Year = 1983,
                Runtime = 170,
                Genres = "Crime,Drama",
                Directors = "Brian De Palma",
                Actors = "Al Pacino, Steven Bauer, Michelle Pfeiffer, Mary Elizabeth Mastrantonio",
                Plot =
                    "In Miami in 1980, a determined Cuban immigrant takes over a drug cartel and succumbs to greed.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjAzOTM4MzEwNl5BMl5BanBnXkFtZTgwMzU1OTc1MDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 20,
                Title = "Sid and Nancy",
                Year = 1986,
                Runtime = 112,
                Genres = "Biography,Drama,Music",
                Directors = "Alex Cox",
                Actors = "Gary Oldman, Chloe Webb, David Hayman, Debby Bishop",
                Plot =
                    "Morbid biographical story of Sid Vicious, bassist with British punk group the Sex Pistols, and his girlfriend Nancy Spungen. When the Sex Pistols break up after their fateful US tour, ...",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjExNjA5NzY4M15BMl5BanBnXkFtZTcwNjQ2NzI5NA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 21,
                Title = "Black Swan",
                Year = 2010,
                Runtime = 108,
                Genres = "Drama,Thriller",
                Directors = "Darren Aronofsky",
                Actors = "Natalie Portman, Mila Kunis, Vincent Cassel, Barbara Hershey",
                Plot =
                    "A committed dancer wins the lead role in a production of Tchaikovsky's 'Swan Lake' only to find herself struggling to maintain her sanity.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNzY2NzI4OTE5MF5BMl5BanBnXkFtZTcwMjMyNDY4Mw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 22,
                Title = "Inception",
                Year = 2010,
                Runtime = 148,
                Genres = "Action,Adventure,Sci-Fi",
                Directors = "Christopher Nolan",
                Actors = "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page, Tom Hardy",
                Plot =
                    "A thief, who steals corporate secrets through use of dream-sharing technology, is given the inverse task of planting an idea into the mind of a CEO.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 23,
                Title = "The Deer Hunter",
                Year = 1978,
                Runtime = 183,
                Genres = "Drama,War",
                Directors = "Michael Cimino",
                Actors = "Robert De Niro, John Cazale, John Savage, Christopher Walken",
                Plot =
                    "An in-depth examination of the ways in which the U.S. Vietnam War impacts and disrupts the lives of people in a small industrial town in Pennsylvania.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTYzYmRmZTQtYjk2NS00MDdlLTkxMDAtMTE2YTM2ZmNlMTBkXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 24,
                Title = "Chasing Amy",
                Year = 1997,
                Runtime = 113,
                Genres = "Comedy,Drama,Romance",
                Directors = "Kevin Smith",
                Actors = "Ethan Suplee, Ben Affleck, Scott Mosier, Jason Lee",
                Plot =
                    "Holden and Banky are comic book artists. Everything's going good for them until they meet Alyssa, also a comic book artist. Holden falls for her, but his hopes are crushed when he finds out she's gay.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BZDM3MTg2MGUtZDM0MC00NzMwLWE5NjItOWFjNjA2M2I4YzgxXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 25,
                Title = "Django Unchained",
                Year = 2012,
                Runtime = 165,
                Genres = "Drama,Western",
                Directors = "Quentin Tarantino",
                Actors = "Jamie Foxx, Christoph Waltz, Leonardo DiCaprio, Kerry Washington",
                Plot =
                    "With the help of a German bounty hunter, a freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 26,
                Title = "The Silence of the Lambs",
                Year = 1991,
                Runtime = 118,
                Genres = "Crime,Drama,Thriller",
                Directors = "Jonathan Demme",
                Actors = "Jodie Foster, Lawrence A. Bonney, Kasi Lemmons, Lawrence T. Wrentz",
                Plot =
                    "A young F.B.I. cadet must confide in an incarcerated and manipulative killer to receive his help on catching another serial killer who skins his victims.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQ2NzkzMDI4OF5BMl5BanBnXkFtZTcwMDA0NzE1NA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 27,
                Title = "American Beauty",
                Year = 1999,
                Runtime = 122,
                Genres = "Drama,Romance",
                Directors = "Sam Mendes",
                Actors = "Kevin Spacey, Annette Bening, Thora Birch, Wes Bentley",
                Plot =
                    "A sexually frustrated suburban father has a mid-life crisis after becoming infatuated with his daughter's best friend.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjM4NTI5NzYyNV5BMl5BanBnXkFtZTgwNTkxNTYxMTE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 28,
                Title = "Snatch",
                Year = 2000,
                Runtime = 102,
                Genres = "Comedy,Crime",
                Directors = "Guy Ritchie",
                Actors = "Benicio Del Toro, Dennis Farina, Vinnie Jones, Brad Pitt",
                Plot =
                    "Unscrupulous boxing promoters, violent bookmakers, a Russian gangster, incompetent amateur robbers, and supposedly Jewish jewelers fight to track down a priceless stolen diamond.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTA2NDYxOGYtYjU1Mi00Y2QzLTgxMTQtMWI1MGI0ZGQ5MmU4XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 29,
                Title = "Midnight Express",
                Year = 1978,
                Runtime = 121,
                Genres = "Crime,Drama,Thriller",
                Directors = "Alan Parker",
                Actors = "Brad Davis, Irene Miracle, Bo Hopkins, Paolo Bonacelli",
                Plot =
                    "Billy Hayes, an American college student, is caught smuggling drugs out of Turkey and thrown into prison.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQyMDA5MzkyOF5BMl5BanBnXkFtZTgwOTYwNTcxMTE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 30,
                Title = "Pulp Fiction",
                Year = 1994,
                Runtime = 154,
                Genres = "Crime,Drama",
                Directors = "Quentin Tarantino",
                Actors = "Tim Roth, Amanda Plummer, Laura Lovelace, John Travolta",
                Plot =
                    "The lives of two mob hit men, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTkxMTA5OTAzMl5BMl5BanBnXkFtZTgwNjA5MDc3NjE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 31,
                Title = "Lock, Stock and Two Smoking Barrels",
                Year = 1998,
                Runtime = 107,
                Genres = "Comedy,Crime",
                Directors = "Guy Ritchie",
                Actors = "Jason Flemyng, Dexter Fletcher, Nick Moran, Jason Statham",
                Plot =
                    "A botched card game in London triggers four friends, thugs, weed-growers, hard gangsters, loan sharks and debt collectors to collide with each other in a series of unexpected events, all for the sake of weed, cash and two antique shotguns.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTAyN2JmZmEtNjAyMy00NzYwLThmY2MtYWQ3OGNhNjExMmM4XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 32,
                Title = "Lucky Number Slevin",
                Year = 2006,
                Runtime = 110,
                Genres = "Crime,Drama,Mystery",
                Directors = "Paul McGuigan",
                Actors = "Josh Hartnett, Bruce Willis, Lucy Liu, Morgan Freeman",
                Plot =
                    "A case of mistaken identity lands Slevin into the middle of a war being plotted by two of the city's most rival crime bosses= The Rabbi and The Boss. Slevin is under constant surveillance by relentless Detective Brikowski as well as the infamous assassin Goodkat and finds himself having to hatch his own ingenious plot to get them before they get him.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMzc1OTEwMTk4OF5BMl5BanBnXkFtZTcwMTEzMDQzMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 33,
                Title = "Rear Window",
                Year = 1954,
                Runtime = 112,
                Genres = "Mystery,Thriller",
                Directors = "Alfred Hitchcock",
                Actors = "James Stewart, Grace Kelly, Wendell Corey, Thelma Ritter",
                Plot =
                    "A wheelchair-bound photographer spies on his neighbours from his apartment window and becomes convinced one of them has committed murder.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNGUxYWM3M2MtMGM3Mi00ZmRiLWE0NGQtZjE5ODI2OTJhNTU0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 34,
                Title = "Pan's Labyrinth",
                Year = 2006,
                Runtime = 118,
                Genres = "Drama,Fantasy,War",
                Directors = "Guillermo del Toro",
                Actors = "Ivana Baquero, Sergi López, Maribel Verdú, Doug Jones",
                Plot =
                    "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.",
                ImageUrl = ""
            },
            new Movie
            {
                Id = 35,
                Title = "Shutter Island",
                Year = 2010,
                Runtime = 138,
                Genres = "Mystery,Thriller",
                Directors = "Martin Scorsese",
                Actors = "Leonardo DiCaprio, Mark Ruffalo, Ben Kingsley, Max von Sydow",
                Plot =
                    "In 1954, a U.S. marshal investigates the disappearance of a murderess who escaped from a hospital for the criminally insane.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTMxMTIyNzMxMV5BMl5BanBnXkFtZTcwOTc4OTI3Mg@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 36,
                Title = "Reservoir Dogs",
                Year = 1992,
                Runtime = 99,
                Genres = "Crime,Drama,Thriller",
                Directors = "Quentin Tarantino",
                Actors = "Harvey Keitel, Tim Roth, Michael Madsen, Chris Penn",
                Plot =
                    "After a simple jewelry heist goes terribly wrong, the surviving criminals begin to suspect that one of them is a police informant.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNjE5ZDJiZTQtOGE2YS00ZTc5LTk0OGUtOTg2NjdjZmVlYzE2XkEyXkFqcGdeQXVyMzM4MjM0Nzg@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 37,
                Title = "The Shining",
                Year = 1980,
                Runtime = 146,
                Genres = "Drama,Horror",
                Directors = "Stanley Kubrick",
                Actors = "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers",
                Plot =
                    "A family heads to an isolated hotel for the winter where an evil and spiritual presence influences the father into violence, while his psychic son sees horrific forebodings from the past and of the future.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BODMxMjE3NTA4Ml5BMl5BanBnXkFtZTgwNDc0NTIxMDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 38,
                Title = "Midnight in Paris",
                Year = 2011,
                Runtime = 94,
                Genres = "Comedy,Fantasy,Romance",
                Directors = "Woody Allen",
                Actors = "Owen Wilson, Rachel McAdams, Kurt Fuller, Mimi Kennedy",
                Plot =
                    "While on a trip to Paris with his fiancée's family, a nostalgic screenwriter finds himself mysteriously going back to the 1920s everyday at midnight.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTM4NjY1MDQwMl5BMl5BanBnXkFtZTcwNTI3Njg3NA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 39,
                Title = "Les Misérables",
                Year = 2012,
                Runtime = 158,
                Genres = "Drama,Musical,Romance",
                Directors = "Tom Hooper",
                Actors = "Hugh Jackman, Russell Crowe, Anne Hathaway, Amanda Seyfried",
                Plot =
                    "In 19th-century France, Jean Valjean, who for decades has been hunted by the ruthless policeman Javert after breaking parole, agrees to care for a factory worker's daughter. The decision changes their lives forever.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTQ4NDI3NDg4M15BMl5BanBnXkFtZTcwMjY5OTI1OA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 40,
                Title = "L.A. Confidential",
                Year = 1997,
                Runtime = 138,
                Genres = "Crime,Drama,Mystery",
                Directors = "Curtis Hanson",
                Actors = "Kevin Spacey, Russell Crowe, Guy Pearce, James Cromwell",
                Plot =
                    "As corruption grows in 1950s LA, three policemen - one strait-laced, one brutal, and one sleazy - investigate a series of murders with their own brand of justice.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNWEwNDhhNWUtYWMzNi00ZTNhLWFiZDAtMjBjZmJhMTU0ZTY2XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 41,
                Title = "Moneyball",
                Year = 2011,
                Runtime = 133,
                Genres = "Biography,Drama,Sport",
                Directors = "Bennett Miller",
                Actors = "Brad Pitt, Jonah Hill, Philip Seymour Hoffman, Robin Wright",
                Plot =
                    "Oakland A's general manager Billy Beane's successful attempt to assemble a baseball team on a lean budget by employing computer-generated analysis to acquire new players.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjAxOTU3Mzc1M15BMl5BanBnXkFtZTcwMzk1ODUzNg@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 42,
                Title = "The Hangover",
                Year = 2009,
                Runtime = 100,
                Genres = "Comedy",
                Directors = "Todd Phillips",
                Actors = "Bradley Cooper, Ed Helms, Zach Galifianakis, Justin Bartha",
                Plot =
                    "Three buddies wake up from a bachelor party in Las Vegas, with no memory of the previous night and the bachelor missing. They make their way around the city in order to find their friend before his wedding.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU1MDA1MTYwMF5BMl5BanBnXkFtZTcwMDcxMzA1Mg@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 43,
                Title = "The Great Beauty",
                Year = 2013,
                Runtime = 141,
                Genres = "Drama",
                Directors = "Paolo Sorrentino",
                Actors = "Toni Servillo, Carlo Verdone, Sabrina Ferilli, Carlo Buccirosso",
                Plot =
                    "Jep Gambardella has seduced his way through the lavish nightlife of Rome for decades, but after his 65th birthday and a shock from the past, Jep looks past the nightclubs and parties to find a timeless landscape of absurd, exquisite beauty.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQ0ODg1OTQ2Nl5BMl5BanBnXkFtZTgwNTc2MDY1MDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 44,
                Title = "Gran Torino",
                Year = 2008,
                Runtime = 116,
                Genres = "Drama",
                Directors = "Clint Eastwood",
                Actors = "Clint Eastwood, Christopher Carley, Bee Vang, Ahney Her",
                Plot =
                    "Disgruntled Korean War veteran Walt Kowalski sets out to reform his neighbor, a Hmong teenager who tried to steal Kowalski's prized possession= a 1972 Gran Torino.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTQyMTczMTAxMl5BMl5BanBnXkFtZTcwOTc1ODE0Mg@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 45,
                Title = "Mary and Max",
                Year = 2009,
                Runtime = 92,
                Genres = "Animation,Comedy,Drama",
                Directors = "Adam Elliot",
                Actors = "Toni Collette, Philip Seymour Hoffman, Barry Humphries, Eric Bana",
                Plot =
                    "A tale of friendship between two unlikely pen pals= Mary, a lonely, eight-year-old girl living in the suburbs of Melbourne, and Max, a forty-four-year old, severely obese man living in New York.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQ1NDIyNTA1Nl5BMl5BanBnXkFtZTcwMjc2Njk3OA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 46,
                Title = "Flight",
                Year = 2012,
                Runtime = 138,
                Genres = "Drama,Thriller",
                Directors = "Robert Zemeckis",
                Actors = "Nadine Velazquez, Denzel Washington, Carter Cabassa, Adam C. Edwards",
                Plot =
                    "An airline pilot saves almost all his passengers on his malfunctioning airliner which eventually crashed, but an investigation into the accident reveals something troubling.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTUxMjI1OTMxNl5BMl5BanBnXkFtZTcwNjc3NTY1OA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 47,
                Title = "One Flew Over the Cuckoo's Nest",
                Year = 1975,
                Runtime = 133,
                Genres = "Drama",
                Directors = "Milos Forman",
                Actors = "Michael Berryman, Peter Brocco, Dean R. Brooks, Alonzo Brown",
                Plot =
                    "A criminal pleads insanity after getting into trouble again and once in the mental institution rebels against the oppressive nurse and rallies up the scared patients.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BYmJkODkwOTItZThjZC00MTE0LWIxNzQtYTM3MmQwMGI1OWFiXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 48,
                Title = "Requiem for a Dream",
                Year = 2000,
                Runtime = 102,
                Genres = "Drama",
                Directors = "Darren Aronofsky",
                Actors = "Ellen Burstyn, Jared Leto, Jennifer Connelly, Marlon Wayans",
                Plot =
                    "The drug-induced utopias of four Coney Island people are shattered when their addictions run deep.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTkzODMzODYwOF5BMl5BanBnXkFtZTcwODM2NjA2NQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 49,
                Title = "The Truman Show",
                Year = 1998,
                Runtime = 103,
                Genres = "Comedy,Drama,Sci-Fi",
                Directors = "Peter Weir",
                Actors = "Jim Carrey, Laura Linney, Noah Emmerich, Natascha McElhone",
                Plot =
                    "An insurance salesman/adjuster discovers his entire life is actually a television show.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMDIzODcyY2EtMmY2MC00ZWVlLTgwMzAtMjQwOWUyNmJjNTYyXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 50,
                Title = "The Artist",
                Year = 2011,
                Runtime = 100,
                Genres = "Comedy,Drama,Romance",
                Directors = "Michel Hazanavicius",
                Actors = "Jean Dujardin, Bérénice Bejo, John Goodman, James Cromwell",
                Plot =
                    "A silent movie star meets a young dancer, but the arrival of talking pictures sends their careers in opposite directions.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMzk0NzQxMTM0OV5BMl5BanBnXkFtZTcwMzU4MDYyNQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 51,
                Title = "Forrest Gump",
                Year = 1994,
                Runtime = 142,
                Genres = "Comedy,Drama",
                Directors = "Robert Zemeckis",
                Actors = "Tom Hanks, Rebecca Williams, Sally Field, Michael Conner Humphreys",
                Plot =
                    "Forrest Gump, while not intelligent, has accidentally been present at many historic moments, but his true love, Jenny Curran, eludes him.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BYThjM2MwZGMtMzg3Ny00NGRkLWE4M2EtYTBiNWMzOTY0YTI4XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 52,
                Title = "The Hobbit= The Desolation of Smaug",
                Year = 2013,
                Runtime = 161,
                Genres = "Adventure,Fantasy",
                Directors = "Peter Jackson",
                Actors = "Ian McKellen, Martin Freeman, Richard Armitage, Ken Stott",
                Plot =
                    "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug. Bilbo Baggins is in possession of a mysterious and magical ring.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMzU0NDY0NDEzNV5BMl5BanBnXkFtZTgwOTIxNDU1MDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 53,
                Title = "Vicky Cristina Barcelona",
                Year = 2008,
                Runtime = 96,
                Genres = "Drama,Romance",
                Directors = "Woody Allen",
                Actors = "Rebecca Hall, Scarlett Johansson, Christopher Evan Welch, Chris Messina",
                Plot =
                    "Two girlfriends on a summer holiday in Spain become enamored with the same painter, unaware that his ex-wife, with whom he has a tempestuous relationship, is about to re-enter the picture.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU2NDQ4MTg2MV5BMl5BanBnXkFtZTcwNDUzNjU3MQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 54,
                Title = "Slumdog Millionaire",
                Year = 2008,
                Runtime = 120,
                Genres = "Drama,Romance",
                Directors = "Danny Boyle, Loveleen Tandan",
                Actors = "Dev Patel, Saurabh Shukla, Anil Kapoor, Rajendranath Zutshi",
                Plot =
                    "A Mumbai teen reflects on his upbringing in the slums when he is accused of cheating on the Indian Version of 'Who Wants to be a Millionaire?'",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTU2NTA5NzI0N15BMl5BanBnXkFtZTcwMjUxMjYxMg@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 55,
                Title = "Lost in Translation",
                Year = 2003,
                Runtime = 101,
                Genres = "Drama",
                Directors = "Sofia Coppola",
                Actors = "Scarlett Johansson, Bill Murray, Akiko Takeshita, Kazuyoshi Minamimagoe",
                Plot =
                    "A faded movie star and a neglected young woman form an unlikely bond after crossing paths in Tokyo.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTI2NDI5ODk4N15BMl5BanBnXkFtZTYwMTI3NTE3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 56,
                Title = "Match Point",
                Year = 2005,
                Runtime = 119,
                Genres = "Drama,Romance,Thriller",
                Directors = "Woody Allen",
                Actors = "Jonathan Rhys Meyers, Alexander Armstrong, Paul Kaye, Matthew Goode",
                Plot =
                    "At a turning point in his life, a former tennis pro falls for an actress who happens to be dating his friend and soon-to-be brother-in-law.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTMzNzY4MzE5NF5BMl5BanBnXkFtZTcwMzQ1MDMzMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 57,
                Title = "Psycho",
                Year = 1960,
                Runtime = 109,
                Genres = "Horror,Mystery,Thriller",
                Directors = "Alfred Hitchcock",
                Actors = "Anthony Perkins, Vera Miles, John Gavin, Janet Leigh",
                Plot =
                    "A Phoenix secretary embezzles $40,000 from her employer's client, goes on the run, and checks into a remote motel run by a young man under the domination of his mother.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMDI3OWRmOTEtOWJhYi00N2JkLTgwNGItMjdkN2U0NjFiZTYwXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 58,
                Title = "North by Northwest",
                Year = 1959,
                Runtime = 136,
                Genres = "Action,Adventure,Crime",
                Directors = "Alfred Hitchcock",
                Actors = "Cary Grant, Eva Marie Saint, James Mason, Jessie Royce Landis",
                Plot =
                    "A hapless New York advertising executive is mistaken for a government agent by a group of foreign spies, and is pursued across the country while he looks for a way to survive.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMjQwMTQ0MzgwNl5BMl5BanBnXkFtZTgwNjc4ODE4MzE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 59,
                Title = "Madagascar= Escape 2 Africa",
                Year = 2008,
                Runtime = 89,
                Genres = "Animation,Action,Adventure",
                Directors = "Eric Darnell, Tom McGrath",
                Actors = "Ben Stiller, Chris Rock, David Schwimmer, Jada Pinkett Smith",
                Plot =
                    "The animals try to fly back to New York City, but crash-land on an African wildlife refuge, where Alex is reunited with his parents.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjExMDA4NDcwMl5BMl5BanBnXkFtZTcwODAxNTQ3MQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 60,
                Title = "Despicable Me 2",
                Year = 2013,
                Runtime = 98,
                Genres = "Animation,Adventure,Comedy",
                Directors = "Pierre Coffin, Chris Renaud",
                Actors = "Steve Carell, Kristen Wiig, Benjamin Bratt, Miranda Cosgrove",
                Plot =
                    "When Gru, the world's most super-bad turned super-dad has been recruited by a team of officials to stop lethal muscle and a host of Gru's own, He has to fight back with new gadgetry, cars, and more minion madness.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjExNjAyNTcyMF5BMl5BanBnXkFtZTgwODQzMjQ3MDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 61,
                Title = "Downfall",
                Year = 2004,
                Runtime = 156,
                Genres = "Biography,Drama,History",
                Directors = "Oliver Hirschbiegel",
                Actors = "Bruno Ganz, Alexandra Maria Lara, Corinna Harfouch, Ulrich Matthes",
                Plot =
                    "Traudl Junge, the final secretary for Adolf Hitler, tells of the Nazi dictator's final days in his Berlin bunker at the end of WWII.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM1OTI1MjE2Nl5BMl5BanBnXkFtZTcwMTEwMzc4NA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 62,
                Title = "Madagascar",
                Year = 2005,
                Runtime = 86,
                Genres = "Animation,Adventure,Comedy",
                Directors = "Eric Darnell, Tom McGrath",
                Actors = "Ben Stiller, Chris Rock, David Schwimmer, Jada Pinkett Smith",
                Plot =
                    "Spoiled by their upbringing with no idea what wild life is really like, four animals from New York Central Zoo escape, unwittingly assisted by four absconding penguins, and find themselves in Madagascar, among a bunch of merry lemurs",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY4NDUwMzQxMF5BMl5BanBnXkFtZTcwMDgwNjgyMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 63,
                Title = "Madagascar 3= Europe's Most Wanted",
                Year = 2012,
                Runtime = 93,
                Genres = "Animation,Adventure,Comedy",
                Directors = "Eric Darnell, Tom McGrath, Conrad Vernon",
                Actors = "Ben Stiller, Chris Rock, David Schwimmer, Jada Pinkett Smith",
                Plot =
                    "Alex, Marty, Gloria and Melman are still fighting to get home to their beloved Big Apple. Their journey takes them through Europe where they find the perfect cover= a traveling circus, which they reinvent - Madagascar style.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM2MTIzNzk2MF5BMl5BanBnXkFtZTcwMDcwMzQxNw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 64,
                Title = "God Bless America",
                Year = 2011,
                Runtime = 105,
                Genres = "Comedy,Crime",
                Directors = "Bobcat Goldthwait",
                Actors =
                    "Joel Murray, Tara Lynne Barr, Melinda Page Hamilton, Mackenzie Brooke Smith",
                Plot =
                    "On a mission to rid society of its most repellent citizens, terminally ill Frank makes an unlikely accomplice in 16-year-old Roxy.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQwMTc1MzA4NF5BMl5BanBnXkFtZTcwNzQwMTgzNw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 65,
                Title = "The Social Network",
                Year = 2010,
                Runtime = 120,
                Genres = "Biography,Drama",
                Directors = "David Fincher",
                Actors = "Jesse Eisenberg, Rooney Mara, Bryan Barter, Dustin Fitzsimons",
                Plot =
                    "Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, but is later sued by two brothers who claimed he stole their idea, and the co-founder who was later squeezed out of the business.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM2ODk0NDAwMF5BMl5BanBnXkFtZTcwNTM1MDc2Mw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 66,
                Title = "The Pianist",
                Year = 2002,
                Runtime = 150,
                Genres = "Biography,Drama,War",
                Directors = "Roman Polanski",
                Actors = "Adrien Brody, Emilia Fox, Michal Zebrowski, Ed Stoppard",
                Plot =
                    "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTc4OTkyOTA3OF5BMl5BanBnXkFtZTYwMDIxNjk5._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 67,
                Title = "Alive",
                Year = 1993,
                Runtime = 120,
                Genres = "Adventure,Biography,Drama",
                Directors = "Frank Marshall",
                Actors = "Ethan Hawke, Vincent Spano, Josh Hamilton, Bruce Ramsay",
                Plot =
                    "Uruguayan rugby team stranded in the snow swept Andes are forced to use desperate measures to survive after a plane crash.",
                ImageUrl = ""
            },
            new Movie
            {
                Id = 68,
                Title = "Casablanca",
                Year = 1942,
                Runtime = 102,
                Genres = "Drama,Romance,War",
                Directors = "Michael Curtiz",
                Actors = "Humphrey Bogart, Ingrid Bergman, Paul Henreid, Claude Rains",
                Plot =
                    "In Casablanca, Morocco in December 1941, a cynical American expatriate meets a former lover, with unforeseen complications.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjQwNDYyNTk2N15BMl5BanBnXkFtZTgwMjQ0OTMyMjE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 69,
                Title = "American Gangster",
                Year = 2007,
                Runtime = 157,
                Genres = "Biography,Crime,Drama",
                Directors = "Ridley Scott",
                Actors = "Denzel Washington, Russell Crowe, Chiwetel Ejiofor, Josh Brolin",
                Plot =
                    "In 1970s America, a detective works to bring down the drug empire of Frank Lucas, a heroin kingpin from Manhattan, who is smuggling the drug into the country from the Far East.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTkyNzY5MDA5MV5BMl5BanBnXkFtZTcwMjg4MzI3MQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 70,
                Title = "Catch Me If You Can",
                Year = 2002,
                Runtime = 141,
                Genres = "Biography,Crime,Drama",
                Directors = "Steven Spielberg",
                Actors = "Leonardo DiCaprio, Tom Hanks, Christopher Walken, Martin Sheen",
                Plot =
                    "The true story of Frank Abagnale Jr. who, before his 19th birthday, successfully conned millions of dollars' worth of checks as a Pan Am pilot, doctor, and legal prosecutor.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY5MzYzNjc5NV5BMl5BanBnXkFtZTYwNTUyNTc2._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 71,
                Title = "American History X",
                Year = 1998,
                Runtime = 119,
                Genres = "Crime,Drama",
                Directors = "Tony Kaye",
                Actors = "Edward Norton, Edward Furlong, Beverly D'Angelo, Jennifer Lien",
                Plot =
                    "A former neo-nazi skinhead tries to prevent his younger brother from going down the same wrong path that he did.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BZjA0MTM4MTQtNzY5MC00NzY3LWI1ZTgtYzcxMjkyMzU4MDZiXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 72,
                Title = "Casino",
                Year = 1995,
                Runtime = 178,
                Genres = "Biography,Crime,Drama",
                Directors = "Martin Scorsese",
                Actors = "Robert De Niro, Sharon Stone, Joe Pesci, James Woods",
                Plot =
                    "Greed, deception, money, power, and murder occur between two best friends, a mafia underboss and a casino owner, for a trophy wife over a gambling empire.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTcxOWYzNDYtYmM4YS00N2NkLTk0NTAtNjg1ODgwZjAxYzI3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 73,
                Title = "Pirates of the Caribbean= At World's End",
                Year = 2007,
                Runtime = 169,
                Genres = "Action,Adventure,Fantasy",
                Directors = "Gore Verbinski",
                Actors = "Johnny Depp, Geoffrey Rush, Orlando Bloom, Keira Knightley",
                Plot =
                    "Captain Barbossa, Will Turner and Elizabeth Swann must sail off the edge of the map, navigate treachery and betrayal, find Jack Sparrow, and make their final alliances for one last decisive battle.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjIyNjkxNzEyMl5BMl5BanBnXkFtZTYwMjc3MDE3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 74,
                Title = "Pirates of the Caribbean= On Stranger Tides",
                Year = 2011,
                Runtime = 136,
                Genres = "Action,Adventure,Fantasy",
                Directors = "Rob Marshall",
                Actors = "Johnny Depp, Penélope Cruz, Geoffrey Rush, Ian McShane",
                Plot =
                    "Jack Sparrow and Barbossa embark on a quest to find the elusive fountain of youth, only to discover that Blackbeard and his daughter are after it too.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMjE5MjkwODI3Nl5BMl5BanBnXkFtZTcwNjcwMDk4NA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 75,
                Title = "Crash",
                Year = 2004,
                Runtime = 112,
                Genres = "Crime,Drama,Thriller",
                Directors = "Paul Haggis",
                Actors = "Karina Arroyave, Dato Bakhtadze, Sandra Bullock, Don Cheadle",
                Plot =
                    "Los Angeles citizens with vastly separate lives collide in interweaving stories of race, loss and redemption.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BOTk1OTA1MjIyNV5BMl5BanBnXkFtZTcwODQxMTkyMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 76,
                Title = "Pirates of the Caribbean= The Curse of the Black Pearl",
                Year = 2003,
                Runtime = 143,
                Genres = "Action,Adventure,Fantasy",
                Directors = "Gore Verbinski",
                Actors = "Johnny Depp, Geoffrey Rush, Orlando Bloom, Keira Knightley",
                Plot =
                    "Blacksmith Will Turner teams up with eccentric pirate 'Captain' Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjAyNDM4MTc2N15BMl5BanBnXkFtZTYwNDk0Mjc3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 77,
                Title = "The Lord of the Rings= The Return of the King",
                Year = 2003,
                Runtime = 201,
                Genres = "Action,Adventure,Drama",
                Directors = "Peter Jackson",
                Actors = "Noel Appleby, Ali Astin, Sean Astin, David Aston",
                Plot =
                    "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjE4MjA1NTAyMV5BMl5BanBnXkFtZTcwNzM1NDQyMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 78,
                Title = "Oldboy",
                Year = 2003,
                Runtime = 120,
                Genres = "Drama,Mystery,Thriller",
                Directors = "Chan-wook Park",
                Actors = "Min-sik Choi, Ji-tae Yu, Hye-jeong Kang, Dae-han Ji",
                Plot =
                    "After being kidnapped and imprisoned for 15 years, Oh Dae-Su is released, only to find that he must find his captor in 5 days.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTI3NTQyMzU5M15BMl5BanBnXkFtZTcwMTM2MjgyMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 79,
                Title = "Chocolat",
                Year = 2000,
                Runtime = 121,
                Genres = "Drama,Romance",
                Directors = "Lasse Hallström",
                Actors = "Alfred Molina, Carrie-Anne Moss, Aurelien Parent Koenig, Antonio Gil",
                Plot =
                    "A woman and her daughter open a chocolate shop in a small French village that shakes up the rigid morality of the community.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA4MDI3NTQwMV5BMl5BanBnXkFtZTcwNjIzNDcyMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 80,
                Title = "Casino Royale",
                Year = 2006,
                Runtime = 144,
                Genres = "Action,Adventure,Thriller",
                Directors = "Martin Campbell",
                Actors = "Daniel Craig, Eva Green, Mads Mikkelsen, Judi Dench",
                Plot =
                    "Armed with a licence to kill, Secret Agent James Bond sets out on his first mission as 007 and must defeat a weapons dealer in a high stakes game of poker at Casino Royale, but things are not what they seem.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM5MjI4NDExNF5BMl5BanBnXkFtZTcwMDM1MjMzMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 81,
                Title = "WALL·E",
                Year = 2008,
                Runtime = 98,
                Genres = "Animation,Adventure,Family",
                Directors = "Andrew Stanton",
                Actors = "Ben Burtt, Elissa Knight, Jeff Garlin, Fred Willard",
                Plot =
                    "In the distant future, a small waste-collecting robot inadvertently embarks on a space journey that will ultimately decide the fate of mankind.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTczOTA3MzY2N15BMl5BanBnXkFtZTcwOTYwNjE2MQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 82,
                Title = "The Wolf of Wall Street",
                Year = 2013,
                Runtime = 180,
                Genres = "Biography,Comedy,Crime",
                Directors = "Martin Scorsese",
                Actors = "Leonardo DiCaprio, Jonah Hill, Margot Robbie, Matthew McConaughey",
                Plot =
                    "Based on the true story of Jordan Belfort, from his rise to a wealthy stock-broker living the high life to his fall involving crime, corruption and the federal government.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 83,
                Title = "Hellboy II= The Golden Army",
                Year = 2008,
                Runtime = 120,
                Genres = "Action,Adventure,Fantasy",
                Directors = "Guillermo del Toro",
                Actors = "Ron Perlman, Selma Blair, Doug Jones, John Alexander",
                Plot =
                    "The mythical world starts a rebellion against humanity in order to rule the Earth, so Hellboy and his team must save the world from the rebellious creatures.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA5NzgyMjc2Nl5BMl5BanBnXkFtZTcwOTU3MDI3MQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 84,
                Title = "Sunset Boulevard",
                Year = 1950,
                Runtime = 110,
                Genres = "Drama,Film-Noir,Romance",
                Directors = "Billy Wilder",
                Actors = "William Holden, Gloria Swanson, Erich von Stroheim, Nancy Olson",
                Plot =
                    "A hack screenwriter writes a screenplay for a former silent-film star who has faded into Hollywood obscurity.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTc3NDYzODAwNV5BMl5BanBnXkFtZTgwODg1MTczMTE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 85,
                Title = "I-See-You.Com",
                Year = 2006,
                Runtime = 92,
                Genres = "Comedy",
                Directors = "Eric Steven Stahl",
                Actors = "Beau Bridges, Rosanna Arquette, Mathew Botuchis, Shiri Appleby",
                Plot =
                    "A 17-year-old boy buys mini-cameras and displays the footage online at I-see-you.com. The cash rolls in as the site becomes a major hit. Everyone seems to have fun until it all comes crashing down....",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTYwMDUzNzA5Nl5BMl5BanBnXkFtZTcwMjQ2Njk3MQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 86,
                Title = "The Grand Budapest Hotel",
                Year = 2014,
                Runtime = 99,
                Genres = "Adventure,Comedy,Crime",
                Directors = "Wes Anderson",
                Actors = "Ralph Fiennes, F. Murray Abraham, Mathieu Amalric, Adrien Brody",
                Plot =
                    "The adventures of Gustave H, a legendary concierge at a famous hotel from the fictional Republic of Zubrowka between the first and second World Wars, and Zero Moustafa, the lobby boy who becomes his most trusted friend.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMzM5NjUxOTEyMl5BMl5BanBnXkFtZTgwNjEyMDM0MDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 87,
                Title = "The Hitchhiker's Guide to the Galaxy",
                Year = 2005,
                Runtime = 109,
                Genres = "Adventure,Comedy,Sci-Fi",
                Directors = "Garth Jennings",
                Actors = "Bill Bailey, Anna Chancellor, Warwick Davis, Yasiin Bey",
                Plot =
                    "Mere seconds before the Earth is to be demolished by an alien construction crew, journeyman Arthur Dent is swept off the planet by his friend Ford Prefect, a researcher penning a new edition of 'The Hitchhiker's Guide to the Galaxy.'",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMjEwOTk4NjU2MF5BMl5BanBnXkFtZTYwMDA3NzI3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 88,
                Title = "Once Upon a Time in America",
                Year = 1984,
                Runtime = 229,
                Genres = "Crime,Drama",
                Directors = "Sergio Leone",
                Actors = "Robert De Niro, James Woods, Elizabeth McGovern, Joe Pesci",
                Plot =
                    "A former Prohibition-era Jewish gangster returns to the Lower East Side of Manhattan over thirty years later, where he once again must confront the ghosts and regrets of his old life.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMGFkNWI4MTMtNGQ0OC00MWVmLTk3MTktOGYxN2Y2YWVkZWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 89,
                Title = "Oblivion",
                Year = 2013,
                Runtime = 124,
                Genres = "Action,Adventure,Mystery",
                Directors = "Joseph Kosinski",
                Actors = "Tom Cruise, Morgan Freeman, Olga Kurylenko, Andrea Riseborough",
                Plot =
                    "A veteran assigned to extract Earth's remaining resources begins to question what he knows about his mission and himself.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQwMDY0MTA4MF5BMl5BanBnXkFtZTcwNzI3MDgxOQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 90,
                Title = "V for Vendetta",
                Year = 2005,
                Runtime = 132,
                Genres = "Action,Drama,Thriller",
                Directors = "James McTeigue",
                Actors = "Natalie Portman, Hugo Weaving, Stephen Rea, Stephen Fry",
                Plot =
                    "In a future British tyranny, a shadowy freedom fighter, known only by the alias of 'V', plots to overthrow it with the help of a young woman.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BOTI5ODc3NzExNV5BMl5BanBnXkFtZTcwNzYxNzQzMw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 91,
                Title = "Gattaca",
                Year = 1997,
                Runtime = 106,
                Genres = "Drama,Sci-Fi,Thriller",
                Directors = "Andrew Niccol",
                Actors = "Ethan Hawke, Uma Thurman, Gore Vidal, Xander Berkeley",
                Plot =
                    "A genetically inferior man assumes the identity of a superior one in order to pursue his lifelong dream of space travel.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNDQxOTc0MzMtZmRlOS00OWQ5LWI2ZDctOTAwNmMwOTYxYzlhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 92,
                Title = "Silver Linings Playbook",
                Year = 2012,
                Runtime = 122,
                Genres = "Comedy,Drama,Romance",
                Directors = "David O. Russell",
                Actors = "Bradley Cooper, Jennifer Lawrence, Robert De Niro, Jacki Weaver",
                Plot =
                    "After a stint in a mental institution, former teacher Pat Solitano moves back in with his parents and tries to reconcile with his ex-wife. Things get more challenging when Pat meets Tiffany, a mysterious girl with problems of her own.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM2MTI5NzA3MF5BMl5BanBnXkFtZTcwODExNTc0OA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 93,
                Title = "Alice in Wonderland",
                Year = 2010,
                Runtime = 108,
                Genres = "Adventure,Family,Fantasy",
                Directors = "Tim Burton",
                Actors = "Johnny Depp, Mia Wasikowska, Helena Bonham Carter, Anne Hathaway",
                Plot =
                    "Nineteen-year-old Alice returns to the magical world from her childhood adventure, where she reunites with her old friends and learns of her true destiny= to end the Red Queen's reign of terror.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTMwNjAxMTc0Nl5BMl5BanBnXkFtZTcwODc3ODk5Mg@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 94,
                Title = "Gandhi",
                Year = 1982,
                Runtime = 191,
                Genres = "Biography,Drama",
                Directors = "Richard Attenborough",
                Actors = "Ben Kingsley, Candice Bergen, Edward Fox, John Gielgud",
                Plot =
                    "Gandhi's character is fully explained as a man of nonviolence. Through his patience, he is able to drive the British out of the subcontinent. And the stubborn nature of Jinnah and his commitment towards Pakistan is portrayed.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMzJiZDRmOWUtYjE2MS00Mjc1LTg1ZDYtNTQxYWJkZTg1OTM4XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 95,
                Title = "Pacific Rim",
                Year = 2013,
                Runtime = 131,
                Genres = "Action,Adventure,Sci-Fi",
                Directors = "Guillermo del Toro",
                Actors = "Charlie Hunnam, Diego Klattenhoff, Idris Elba, Rinko Kikuchi",
                Plot =
                    "As a war between humankind and monstrous sea creatures wages on, a former pilot and a trainee are paired up to drive a seemingly obsolete special weapon in a desperate effort to save the world from the apocalypse.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY3MTI5NjQ4Nl5BMl5BanBnXkFtZTcwOTU1OTU0OQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 96,
                Title = "Kiss Kiss Bang Bang",
                Year = 2005,
                Runtime = 103,
                Genres = "Comedy,Crime,Mystery",
                Directors = "Shane Black",
                Actors = "Robert Downey Jr., Val Kilmer, Michelle Monaghan, Corbin Bernsen",
                Plot =
                    "A murder mystery brings together a private eye, a struggling actress, and a thief masquerading as an actor.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTY5NDExMDA3M15BMl5BanBnXkFtZTYwNTc2MzA3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 97,
                Title = "The Quiet American",
                Year = 2002,
                Runtime = 101,
                Genres = "Drama,Mystery,Romance",
                Directors = "Phillip Noyce",
                Actors = "Michael Caine, Brendan Fraser, Do Thi Hai Yen, Rade Serbedzija",
                Plot =
                    "An older British reporter vies with a young U.S. doctor for the affections of a beautiful Vietnamese woman.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMjE2NTUxNTE3Nl5BMl5BanBnXkFtZTYwNTczMTg5._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 98,
                Title = "Cloud Atlas",
                Year = 2012,
                Runtime = 172,
                Genres = "Drama,Sci-Fi",
                Directors = "Tom Tykwer, Lana Wachowski, Lilly Wachowski",
                Actors = "Tom Hanks, Halle Berry, Jim Broadbent, Hugo Weaving",
                Plot =
                    "An exploration of how the actions of individual lives impact one another in the past, present and future, as one soul is shaped from a killer into a hero, and an act of kindness ripples across centuries to inspire a revolution.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTczMTgxMjc4NF5BMl5BanBnXkFtZTcwNjM5MTA2OA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 99,
                Title = "The Impossible",
                Year = 2012,
                Runtime = 114,
                Genres = "Drama,Thriller",
                Directors = "J.A. Bayona",
                Actors = "Naomi Watts, Ewan McGregor, Tom Holland, Samuel Joslin",
                Plot =
                    "The story of a tourist family in Thailand caught in the destruction and chaotic aftermath of the 2004 Indian Ocean tsunami.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA5NTA3NzQ5Nl5BMl5BanBnXkFtZTcwOTYxNjY0OA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 100,
                Title = "All Quiet on the Western Front",
                Year = 1930,
                Runtime = 136,
                Genres = "Drama,War",
                Directors = "Lewis Milestone",
                Actors = "Louis Wolheim, Lew Ayres, John Wray, Arnold Lucy",
                Plot =
                    "A young soldier faces profound disillusionment in the soul-destroying horror of World War I.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNTM5OTg2NDY1NF5BMl5BanBnXkFtZTcwNTQ4MTMwNw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 101,
                Title = "The English Patient",
                Year = 1996,
                Runtime = 162,
                Genres = "Drama,Romance,War",
                Directors = "Anthony Minghella",
                Actors = "Ralph Fiennes, Juliette Binoche, Willem Dafoe, Kristin Scott Thomas",
                Plot =
                    "At the close of WWII, a young nurse tends to a badly-burned plane crash victim. His past is shown in flashbacks, revealing an involvement in a fateful love affair.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNDg2OTcxNDE0OF5BMl5BanBnXkFtZTgwOTg2MDM0MDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 102,
                Title = "Dallas Buyers Club",
                Year = 2013,
                Runtime = 117,
                Genres = "Biography,Drama",
                Directors = "Jean-Marc Vallée",
                Actors = "Matthew McConaughey, Jennifer Garner, Jared Leto, Denis O'Hare",
                Plot =
                    "In 1985 Dallas, electrician and hustler Ron Woodroof works around the system to help AIDS patients get the medication they need after he is diagnosed with the disease.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTYwMTA4MzgyNF5BMl5BanBnXkFtZTgwMjEyMjE0MDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 103,
                Title = "Frida",
                Year = 2002,
                Runtime = 123,
                Genres = "Biography,Drama,Romance",
                Directors = "Julie Taymor",
                Actors = "Salma Hayek, Mía Maestro, Alfred Molina, Antonio Banderas",
                Plot =
                    "A biography of artist Frida Kahlo, who channeled the pain of a crippling injury and her tempestuous marriage into her work.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTMyODUyMDY1OV5BMl5BanBnXkFtZTYwMDA2OTU3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 104,
                Title = "Before Sunrise",
                Year = 1995,
                Runtime = 105,
                Genres = "Drama,Romance",
                Directors = "Richard Linklater",
                Actors = "Ethan Hawke, Julie Delpy, Andrea Eckert, Hanno Pöschl",
                Plot =
                    "A young man and woman meet on a train in Europe, and wind up spending one evening together in Vienna. Unfortunately, both know that this will probably be their only night together.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQyMTM3MTQxMl5BMl5BanBnXkFtZTcwMDAzNjQ4Mg@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 105,
                Title = "The Rum Diary",
                Year = 2011,
                Runtime = 120,
                Genres = "Comedy,Drama",
                Directors = "Bruce Robinson",
                Actors = "Johnny Depp, Aaron Eckhart, Michael Rispoli, Amber Heard",
                Plot =
                    "American journalist Paul Kemp takes on a freelance job in Puerto Rico for a local newspaper during the 1960s and struggles to find a balance between island culture and the expatriates who live there.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM5ODA4MjYxM15BMl5BanBnXkFtZTcwMTM3NTE5Ng@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 106,
                Title = "The Last Samurai",
                Year = 2003,
                Runtime = 154,
                Genres = "Action,Drama,History",
                Directors = "Edward Zwick",
                Actors = "Ken Watanabe, Tom Cruise, William Atherton, Chad Lindberg",
                Plot =
                    "An American military advisor embraces the Samurai culture he was hired to destroy after he is captured in battle.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMzkyNzQ1Mzc0NV5BMl5BanBnXkFtZTcwODg3MzUzMw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 107,
                Title = "Chinatown",
                Year = 1974,
                Runtime = 130,
                Genres = "Drama,Mystery,Thriller",
                Directors = "Roman Polanski",
                Actors = "Jack Nicholson, Faye Dunaway, John Huston, Perry Lopez",
                Plot =
                    "A private detective hired to expose an adulterer finds himself caught up in a web of deceit, corruption and murder.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BN2YyNDE5NzItMjAwNC00MGQxLTllNjktZGIzMWFkZjA3OWQ0XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 108,
                Title = "Calvary",
                Year = 2014,
                Runtime = 102,
                Genres = "Comedy,Drama",
                Directors = "John Michael McDonagh",
                Actors = "Brendan Gleeson, Chris O'Dowd, Kelly Reilly, Aidan Gillen",
                Plot =
                    "After he is threatened during a confession, a good-natured priest must battle the dark forces closing in around him.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTc3MjQ1MjE2M15BMl5BanBnXkFtZTgwNTMzNjE4MTE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 109,
                Title = "Before Sunset",
                Year = 2004,
                Runtime = 80,
                Genres = "Drama,Romance",
                Directors = "Richard Linklater",
                Actors = "Ethan Hawke, Julie Delpy, Vernon Dobtcheff, Louise Lemoine Torrès",
                Plot =
                    "Nine years after Jesse and Celine first met, they encounter each other again on the French leg of Jesse's book tour.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTQ1MjAwNTM5Ml5BMl5BanBnXkFtZTYwNDM0MTc3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 110,
                Title = "Spirited Away",
                Year = 2001,
                Runtime = 125,
                Genres = "Animation,Adventure,Family",
                Directors = "Hayao Miyazaki",
                Actors = "Rumi Hiiragi, Miyu Irino, Mari Natsuki, Takashi Naitô",
                Plot =
                    "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjYxMDcyMzIzNl5BMl5BanBnXkFtZTYwNDg2MDU3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 111,
                Title = "Indochine",
                Year = 1992,
                Runtime = 159,
                Genres = "Drama,Romance",
                Directors = "Régis Wargnier",
                Actors = "Catherine Deneuve, Vincent Perez, Linh Dan Pham, Jean Yanne",
                Plot =
                    "This story is set in 1930, at the time when French colonial rule in Indochina is ending. A widowed French woman who works in the rubber fields, raises a Vietnamese princess as if she was ...",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM1MTkzNzA3NF5BMl5BanBnXkFtZTYwNTI2MzU5._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 112,
                Title = "Birdman or (The Unexpected Virtue of Ignorance)",
                Year = 2014,
                Runtime = 119,
                Genres = "Comedy,Drama,Romance",
                Directors = "Alejandro G. Iñárritu",
                Actors = "Michael Keaton, Emma Stone, Kenny Chin, Jamahl Garrison-Lowe",
                Plot =
                    "Illustrated upon the progress of his latest Broadway play, a former popular actor's struggle to cope with his current life as a wasted actor is shown.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BODAzNDMxMzAxOV5BMl5BanBnXkFtZTgwMDMxMjA4MjE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 113,
                Title = "Boyhood",
                Year = 2014,
                Runtime = 165,
                Genres = "Drama",
                Directors = "Richard Linklater",
                Actors = "Ellar Coltrane, Patricia Arquette, Elijah Smith, Lorelei Linklater",
                Plot = "The life of Mason, from early childhood to his arrival at college.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTYzNDc2MDc0N15BMl5BanBnXkFtZTgwOTcwMDQ5MTE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 114,
                Title = "12 Angry Men",
                Year = 1957,
                Runtime = 96,
                Genres = "Crime,Drama",
                Directors = "Sidney Lumet",
                Actors = "Martin Balsam, John Fiedler, Lee J. Cobb, E.G. Marshall",
                Plot =
                    "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BODQwOTc5MDM2N15BMl5BanBnXkFtZTcwODQxNTEzNA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 115,
                Title = "The Imitation Game",
                Year = 2014,
                Runtime = 114,
                Genres = "Biography,Drama,Thriller",
                Directors = "Morten Tyldum",
                Actors = "Benedict Cumberbatch, Keira Knightley, Matthew Goode, Rory Kinnear",
                Plot =
                    "During World War II, mathematician Alan Turing tries to crack the enigma code with help from fellow mathematicians.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNDkwNTEyMzkzNl5BMl5BanBnXkFtZTgwNTAwNzk3MjE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 116,
                Title = "Interstellar",
                Year = 2014,
                Runtime = 169,
                Genres = "Adventure,Drama,Sci-Fi",
                Directors = "Christopher Nolan",
                Actors = "Ellen Burstyn, Matthew McConaughey, Mackenzie Foy, John Lithgow",
                Plot =
                    "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjIxNTU4MzY4MF5BMl5BanBnXkFtZTgwMzM4ODI3MjE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 117,
                Title = "Big Nothing",
                Year = 2006,
                Runtime = 86,
                Genres = "Comedy,Crime,Thriller",
                Directors = "Jean-Baptiste Andrea",
                Actors = "David Schwimmer, Simon Pegg, Alice Eve, Natascha McElhone",
                Plot =
                    "A frustrated, unemployed teacher joining forces with a scammer and his girlfriend in a blackmailing scheme.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY5NTc2NjYwOV5BMl5BanBnXkFtZTcwMzk5OTY0MQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 118,
                Title = "Das Boot",
                Year = 1981,
                Runtime = 149,
                Genres = "Adventure,Drama,Thriller",
                Directors = "Wolfgang Petersen",
                Actors = "Jürgen Prochnow, Herbert Grönemeyer, Klaus Wennemann, Hubertus Bengsch",
                Plot =
                    "The claustrophobic world of a WWII German U-boat; boredom, filth, and sheer terror.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjE5Mzk5OTQ0Nl5BMl5BanBnXkFtZTYwNzUwMTQ5._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 119,
                Title = "Shrek 2",
                Year = 2004,
                Runtime = 93,
                Genres = "Animation,Adventure,Comedy",
                Directors = "Andrew Adamson, Kelly Asbury, Conrad Vernon",
                Actors = "Mike Myers, Eddie Murphy, Cameron Diaz, Julie Andrews",
                Plot =
                    "Princess Fiona's parents invite her and Shrek to dinner to celebrate her marriage. If only they knew the newlyweds were both ogres.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTk4MTMwNjI4M15BMl5BanBnXkFtZTcwMjExMzUyMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 120,
                Title = "Sin City",
                Year = 2005,
                Runtime = 124,
                Genres = "Crime,Thriller",
                Directors = "Frank Miller, Robert Rodriguez, Quentin Tarantino",
                Actors = "Jessica Alba, Devon Aoki, Alexis Bledel, Powers Boothe",
                Plot =
                    "A film that explores the dark and miserable town, Basin City, and tells the story of three different people, all caught up in violent corruption.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BODZmYjMwNzEtNzVhNC00ZTRmLTk2M2UtNzE1MTQ2ZDAxNjc2XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 121,
                Title = "Nebraska",
                Year = 2013,
                Runtime = 115,
                Genres = "Adventure,Comedy,Drama",
                Directors = "Alexander Payne",
                Actors = "Bruce Dern, Will Forte, June Squibb, Bob Odenkirk",
                Plot =
                    "An aging, booze-addled father makes the trip from Montana to Nebraska with his estranged son in order to claim a million-dollar Mega Sweepstakes Marketing prize.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU2Mjk2NDkyMl5BMl5BanBnXkFtZTgwNTk0NzcyMDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 122,
                Title = "Shrek",
                Year = 2001,
                Runtime = 90,
                Genres = "Animation,Adventure,Comedy",
                Directors = "Andrew Adamson, Vicky Jenson",
                Actors = "Mike Myers, Eddie Murphy, Cameron Diaz, John Lithgow",
                Plot =
                    "After his swamp is filled with magical creatures, an ogre agrees to rescue a princess for a villainous lord in order to get his land back.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTk2NTE1NTE0M15BMl5BanBnXkFtZTgwNjY4NTYxMTE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 123,
                Title = "Mr. & Mrs. Smith",
                Year = 2005,
                Runtime = 120,
                Genres = "Action,Comedy,Crime",
                Directors = "Doug Liman",
                Actors = "Brad Pitt, Angelina Jolie, Vince Vaughn, Adam Brody",
                Plot =
                    "A bored married couple is surprised to learn that they are both assassins hired by competing agencies to kill each other.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTUxMzcxNzQzOF5BMl5BanBnXkFtZTcwMzQxNjUyMw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 124,
                Title = "Original Sin",
                Year = 2001,
                Runtime = 116,
                Genres = "Drama,Mystery,Romance",
                Directors = "Michael Cristofer",
                Actors = "Antonio Banderas, Angelina Jolie, Thomas Jane, Jack Thompson",
                Plot =
                    "A woman along with her lover, plan to con a rich man by marrying him and on earning his trust running away with all his money. Everything goes as planned until she actually begins to fall in love with him.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BODg3Mjg0MDY4M15BMl5BanBnXkFtZTcwNjY5MDQ2NA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 125,
                Title = "Shrek Forever After",
                Year = 2010,
                Runtime = 93,
                Genres = "Animation,Adventure,Comedy",
                Directors = "Mike Mitchell",
                Actors = "Mike Myers, Eddie Murphy, Cameron Diaz, Antonio Banderas",
                Plot =
                    "Rumpelstiltskin tricks a mid-life crisis burdened Shrek into allowing himself to be erased from existence and cast in a dark alternate timeline where Rumpel rules supreme.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTY0OTU1NzkxMl5BMl5BanBnXkFtZTcwMzI2NDUzMw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 126,
                Title = "Before Midnight",
                Year = 2013,
                Runtime = 109,
                Genres = "Drama,Romance",
                Directors = "Richard Linklater",
                Actors = "Ethan Hawke, Julie Delpy, Seamus Davey-Fitzpatrick, Jennifer Prior",
                Plot =
                    "We meet Jesse and Celine nine years on in Greece. Almost two decades have passed since their first meeting on that train bound for Vienna.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMjA5NzgxODE2NF5BMl5BanBnXkFtZTcwNTI1NTI0OQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 127,
                Title = "Despicable Me",
                Year = 2010,
                Runtime = 95,
                Genres = "Animation,Adventure,Comedy",
                Directors = "Pierre Coffin, Chris Renaud",
                Actors = "Steve Carell, Jason Segel, Russell Brand, Julie Andrews",
                Plot =
                    "When a criminal mastermind uses a trio of orphan girls as pawns for a grand scheme, he finds their love is profoundly changing him for the better.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY3NjY0MTQ0Nl5BMl5BanBnXkFtZTcwMzQ2MTc0Mw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 128,
                Title = "Troy",
                Year = 2004,
                Runtime = 163,
                Genres = "Adventure",
                Directors = "Wolfgang Petersen",
                Actors = "Julian Glover, Brian Cox, Nathan Jones, Adoni Maropis",
                Plot =
                    "An adaptation of Homer's great epic, the film follows the assault on Troy by the united Greek forces and chronicles the fates of the men involved.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTk5MzU1MDMwMF5BMl5BanBnXkFtZTcwNjczODMzMw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 129,
                Title = "The Hobbit= An Unexpected Journey",
                Year = 2012,
                Runtime = 169,
                Genres = "Adventure,Fantasy",
                Directors = "Peter Jackson",
                Actors = "Ian McKellen, Martin Freeman, Richard Armitage, Ken Stott",
                Plot =
                    "A reluctant hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home - and the gold within it - from the dragon Smaug.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTcwNTE4MTUxMl5BMl5BanBnXkFtZTcwMDIyODM4OA@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 130,
                Title = "The Great Gatsby",
                Year = 2013,
                Runtime = 143,
                Genres = "Drama,Romance",
                Directors = "Baz Luhrmann",
                Actors = "Lisa Adam, Frank Aldridge, Amitabh Bachchan, Steve Bisley",
                Plot =
                    "A writer and wall street trader, Nick, finds himself drawn to the past and lifestyle of his millionaire neighbor, Jay Gatsby.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTkxNTk1ODcxNl5BMl5BanBnXkFtZTcwMDI1OTMzOQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 131,
                Title = "Ice Age",
                Year = 2002,
                Runtime = 81,
                Genres = "Animation,Adventure,Comedy",
                Directors = "Chris Wedge, Carlos Saldanha",
                Actors = "Ray Romano, John Leguizamo, Denis Leary, Goran Visnjic",
                Plot =
                    "Set during the Ice Age, a sabertooth tiger, a sloth, and a wooly mammoth find a lost human infant, and they try to return him to his tribe.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjEyNzI1ODA0MF5BMl5BanBnXkFtZTYwODIxODY3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 132,
                Title = "The Lord of the Rings= The Fellowship of the Ring",
                Year = 2001,
                Runtime = 178,
                Genres = "Action,Adventure,Drama",
                Directors = "Peter Jackson",
                Actors = "Alan Howard, Noel Appleby, Sean Astin, Sala Baker",
                Plot =
                    "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle Earth from the Dark Lord Sauron.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNTEyMjAwMDU1OV5BMl5BanBnXkFtZTcwNDQyNTkxMw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 133,
                Title = "The Lord of the Rings= The Two Towers",
                Year = 2002,
                Runtime = 179,
                Genres = "Action,Adventure,Drama",
                Directors = "Peter Jackson",
                Actors = "Bruce Allpress, Sean Astin, John Bach, Sala Baker",
                Plot =
                    "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTAyNDU0NjY4NTheQTJeQWpwZ15BbWU2MDk4MTY2Nw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 134,
                Title = "Ex Machina",
                Year = 2015,
                Runtime = 108,
                Genres = "Drama,Mystery,Sci-Fi",
                Directors = "Alex Garland",
                Actors = "Domhnall Gleeson, Corey Johnson, Oscar Isaac, Alicia Vikander",
                Plot =
                    "A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a breath-taking humanoid A.I.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 135,
                Title = "The Theory of Everything",
                Year = 2014,
                Runtime = 123,
                Genres = "Biography,Drama,Romance",
                Directors = "James Marsh",
                Actors = "Eddie Redmayne, Felicity Jones, Tom Prior, Sophie Perry",
                Plot =
                    "A look at the relationship between the famous physicist Stephen Hawking and his wife.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTAwMTU4MDA3NDNeQTJeQWpwZ15BbWU4MDk4NTMxNTIx._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 136,
                Title = "Shogun",
                Year = 1980,
                Runtime = 60,
                Genres = "Adventure,Drama,History",
                Directors = "N/A",
                Actors = "Richard Chamberlain, Toshirô Mifune, Yôko Shimada, Furankî Sakai",
                Plot =
                    "A English navigator becomes both a player and pawn in the complex political games in feudal Japan.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY1ODI4NzYxMl5BMl5BanBnXkFtZTcwNDA4MzUxMQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 137,
                Title = "Spotlight",
                Year = 2015,
                Runtime = 128,
                Genres = "Biography,Crime,Drama",
                Directors = "Tom McCarthy",
                Actors = "Mark Ruffalo, Michael Keaton, Rachel McAdams, Liev Schreiber",
                Plot =
                    "The true story of how the Boston Globe uncovered the massive scandal of child molestation and cover-up within the local Catholic Archdiocese, shaking the entire Catholic Church to its core.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjIyOTM5OTIzNV5BMl5BanBnXkFtZTgwMDkzODE2NjE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 138,
                Title = "Vertigo",
                Year = 1958,
                Runtime = 128,
                Genres = "Mystery,Romance,Thriller",
                Directors = "Alfred Hitchcock",
                Actors = "James Stewart, Kim Novak, Barbara Bel Geddes, Tom Helmore",
                Plot =
                    "A San Francisco detective suffering from acrophobia investigates the strange activities of an old friend's wife, all the while becoming dangerously obsessed with her.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BNzY0NzQyNzQzOF5BMl5BanBnXkFtZTcwMTgwNTk4OQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 139,
                Title = "Whiplash",
                Year = 2014,
                Runtime = 107,
                Genres = "Drama,Music",
                Directors = "Damien Chazelle",
                Actors = "Miles Teller, J.K. Simmons, Paul Reiser, Melissa Benoist",
                Plot =
                    "A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student's potential.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU4OTQ3MDUyMV5BMl5BanBnXkFtZTgwOTA2MjU0MjE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 140,
                Title = "The Lives of Others",
                Year = 2006,
                Runtime = 137,
                Genres = "Drama,Thriller",
                Directors = "Florian Henckel von Donnersmarck",
                Actors = "Martina Gedeck, Ulrich Mühe, Sebastian Koch, Ulrich Tukur",
                Plot =
                    "In 1984 East Berlin, an agent of the secret police, conducting surveillance on a writer and his lover, finds himself becoming increasingly absorbed by their lives.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BNDUzNjYwNDYyNl5BMl5BanBnXkFtZTcwNjU3ODQ0MQ@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 141,
                Title = "Hotel Rwanda",
                Year = 2004,
                Runtime = 121,
                Genres = "Drama,History,War",
                Directors = "Terry George",
                Actors = "Xolani Mali, Don Cheadle, Desmond Dube, Hakeem Kae-Kazim",
                Plot =
                    "Paul Rusesabagina was a hotel manager who housed over a thousand Tutsi refugees during their struggle against the Hutu militia in Rwanda.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTI2MzQyNTc1M15BMl5BanBnXkFtZTYwMjExNjc3._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 142,
                Title = "The Martian",
                Year = 2015,
                Runtime = 144,
                Genres = "Adventure,Drama,Sci-Fi",
                Directors = "Ridley Scott",
                Actors = "Matt Damon, Jessica Chastain, Kristen Wiig, Jeff Daniels",
                Plot =
                    "An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTc2MTQ3MDA1Nl5BMl5BanBnXkFtZTgwODA3OTI4NjE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 143,
                Title = "To Kill a Mockingbird",
                Year = 1962,
                Runtime = 129,
                Genres = "Crime,Drama",
                Directors = "Robert Mulligan",
                Actors = "Gregory Peck, John Megna, Frank Overton, Rosemary Murphy",
                Plot =
                    "Atticus Finch, a lawyer in the Depression-era South, defends a black man against an undeserved rape charge, and his kids against prejudice.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMjA4MzI1NDY2Nl5BMl5BanBnXkFtZTcwMTcyODc5Mw@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 144,
                Title = "The Hateful Eight",
                Year = 2015,
                Runtime = 187,
                Genres = "Crime,Drama,Mystery",
                Directors = "Quentin Tarantino",
                Actors = "Samuel L. Jackson, Kurt Russell, Jennifer Jason Leigh, Walton Goggins",
                Plot =
                    "In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA1MTc1NTg5NV5BMl5BanBnXkFtZTgwOTM2MDEzNzE@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 145,
                Title = "A Separation",
                Year = 2011,
                Runtime = 123,
                Genres = "Drama,Mystery",
                Directors = "Asghar Farhadi",
                Actors = "Peyman Moaadi, Leila Hatami, Sareh Bayat, Shahab Hosseini",
                Plot =
                    "A married couple are faced with a difficult decision - to improve the life of their child by moving to another country or to stay in Iran and look after a deteriorating parent who has Alzheimer's disease.",
                ImageUrl =
                    "http=//ia.media-imdb.com/images/M/MV5BMTYzMzU4NDUwOF5BMl5BanBnXkFtZTcwMTM5MjA5Ng@@._V1_SX300.jpg"
            },
            new Movie
            {
                Id = 146,
                Title = "The Big Short",
                Year = 2015,
                Runtime = 130,
                Genres = "Biography,Comedy,Drama",
                Directors = "Adam McKay",
                Actors = "Ryan Gosling, Rudy Eisenzopf, Casey Groves, Charlie Talbert",
                Plot =
                    "Four denizens in the world of high-finance predict the credit and housing bubble collapse of the mid-2000s, and decide to take on the big banks for their greed and lack of foresight.",
                ImageUrl =
                    "https=//images-na.ssl-images-amazon.com/images/M/MV5BNDc4MThhN2EtZjMzNC00ZDJmLThiZTgtNThlY2UxZWMzNjdkXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg"
            }
        };
    }
}
