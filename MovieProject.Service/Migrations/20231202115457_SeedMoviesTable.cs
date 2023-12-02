﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieProject.Service.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoviesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[]
                {
                    "Id",
                    "Actors",
                    "Directors",
                    "Genres",
                    "ImageUrl",
                    "Plot",
                    "Runtime",
                    "Title",
                    "Year"
                },
                values: new object[,]
                {
                    {
                        1,
                        "Alec Baldwin, Geena Davis, Annie McEnroe, Maurice Page",
                        "Tim Burton",
                        "Comedy,Fantasy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTUwODE3MDE0MV5BMl5BanBnXkFtZTgwNTk1MjI4MzE@._V1_SX300.jpg",
                        "A couple of recently deceased ghosts contract the services of a 'bio-exorcist' in order to remove the obnoxious new owners of their house.",
                        92,
                        "Beetlejuice",
                        1988
                    },
                    {
                        2,
                        "Richard Gere, Gregory Hines, Diane Lane, Lonette McKee",
                        "Francis Ford Coppola",
                        "Crime,Drama,Music",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU5ODAyNzA4OV5BMl5BanBnXkFtZTcwNzYwNTIzNA@@._V1_SX300.jpg",
                        "The Cotton Club was a famous night club in Harlem. The story follows the people that visited the club, those that ran it, and is peppered with the Jazz music that made it so famous.",
                        127,
                        "The Cotton Club",
                        1984
                    },
                    {
                        3,
                        "Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler",
                        "Frank Darabont",
                        "Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BODU4MjU4NjIwNl5BMl5BanBnXkFtZTgwMDU2MjEyMDE@._V1_SX300.jpg",
                        "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                        142,
                        "The Shawshank Redemption",
                        1994
                    },
                    {
                        4,
                        "Paul Hogan, Linda Kozlowski, John Meillon, David Gulpilil",
                        "Peter Faiman",
                        "Adventure,Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTg0MTU1MTg4NF5BMl5BanBnXkFtZTgwMDgzNzYxMTE@._V1_SX300.jpg",
                        "An American reporter goes to the Australian outback to meet an eccentric crocodile poacher and invites him to New York City.",
                        97,
                        "Crocodile Dundee",
                        1986
                    },
                    {
                        5,
                        "Tom Cruise, Kenneth Branagh, Bill Nighy, Tom Wilkinson",
                        "Bryan Singer",
                        "Drama,History,Thriller",
                        "http=//ia.media-imdb.com/images/M/MV5BMTg3Njc2ODEyN15BMl5BanBnXkFtZTcwNTAwMzc3NA@@._V1_SX300.jpg",
                        "A dramatization of the 20 July assassination and political coup plot by desperate renegade German Army officers against Hitler during World War II.",
                        121,
                        "Valkyrie",
                        2008
                    },
                    {
                        6,
                        "Patton Oswalt, Ian Holm, Lou Romano, Brian Dennehy",
                        "Brad Bird, Jan Pinkava",
                        "Animation,Comedy,Family",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTMzODU0NTkxMF5BMl5BanBnXkFtZTcwMjQ4MzMzMw@@._V1_SX300.jpg",
                        "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous restaurant.",
                        111,
                        "Ratatouille",
                        2007
                    },
                    {
                        7,
                        "Alexandre Rodrigues, Leandro Firmino, Phellipe Haagensen, Douglas Silva",
                        "Fernando Meirelles, Kátia Lund",
                        "Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA4ODQ3ODkzNV5BMl5BanBnXkFtZTYwOTc4NDI3._V1_SX300.jpg",
                        "Two boys growing up in a violent neighborhood of Rio de Janeiro take different paths= one becomes a photographer, the other a drug dealer.",
                        130,
                        "City of God",
                        2002
                    },
                    {
                        8,
                        "Guy Pearce, Carrie-Anne Moss, Joe Pantoliano, Mark Boone Junior",
                        "Christopher Nolan",
                        "Mystery,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNThiYjM3MzktMDg3Yy00ZWQ3LTk3YWEtN2M0YmNmNWEwYTE3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                        "A man juggles searching for his wife's murderer and keeping his short-term memory loss from being an obstacle.",
                        113,
                        "Memento",
                        2000
                    },
                    {
                        9,
                        "François Cluzet, Omar Sy, Anne Le Ny, Audrey Fleurot",
                        "Olivier Nakache, Eric Toledano",
                        "Biography,Comedy,Drama",
                        "http=//ia.media-imdb.com/images/M/MV5BMTYxNDA3MDQwNl5BMl5BanBnXkFtZTcwNTU4Mzc1Nw@@._V1_SX300.jpg",
                        "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.",
                        112,
                        "The Intouchables",
                        2011
                    },
                    {
                        10,
                        "Ian McKellen, Bimbo Hart, Alastair MacIntosh, David Kelly",
                        "Matthew Vaughn",
                        "Adventure,Family,Fantasy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjkyMTE1OTYwNF5BMl5BanBnXkFtZTcwMDIxODYzMw@@._V1_SX300.jpg",
                        "In a countryside town bordering on a magical land, a young man makes a promise to his beloved that he'll retrieve a fallen star by venturing into the magical realm.",
                        127,
                        "Stardust",
                        2007
                    },
                    {
                        11,
                        "Rudy Youngblood, Dalia Hernández, Jonathan Brewer, Morris Birdyellowhead",
                        "Mel Gibson",
                        "Action,Adventure,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNTM1NjYyNTY5OV5BMl5BanBnXkFtZTcwMjgwNTMzMQ@@._V1_SX300.jpg",
                        "As the Mayan kingdom faces its decline, the rulers insist the key to prosperity is to build more temples and offer human sacrifices. Jaguar Paw, a young man captured for sacrifice, flees to avoid his fate.",
                        139,
                        "Apocalypto",
                        2006
                    },
                    {
                        12,
                        "Diahnne Abbott, Frank Adu, Victor Argo, Gino Ardito",
                        "Martin Scorsese",
                        "Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNGQxNDgzZWQtZTNjNi00M2RkLWExZmEtNmE1NjEyZDEwMzA5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                        "A mentally unstable Vietnam War veteran works as a night-time taxi driver in New York City where the perceived decadence and sleaze feeds his urge for violent action, attempting to save a preadolescent prostitute in the process.",
                        113,
                        "Taxi Driver",
                        1976
                    },
                    {
                        13,
                        "Tommy Lee Jones, Javier Bardem, Josh Brolin, Woody Harrelson",
                        "Ethan Coen, Joel Coen",
                        "Crime,Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA5Njk3MjM4OV5BMl5BanBnXkFtZTcwMTc5MTE1MQ@@._V1_SX300.jpg",
                        "Violence and mayhem ensue after a hunter stumbles upon a drug deal gone wrong and more than two million dollars in cash near the Rio Grande.",
                        122,
                        "No Country for Old Men",
                        2007
                    },
                    {
                        14,
                        "Jessica Biel, John Cleese, Gary Oldman, Dwayne Johnson",
                        "Jorge Blanco, Javier Abad, Marcos Martínez",
                        "Animation,Adventure,Comedy",
                        "http=//ia.media-imdb.com/images/M/MV5BMTUyOTAyNTA5Ml5BMl5BanBnXkFtZTcwODU2OTM0Mg@@._V1_SX300.jpg",
                        "An alien civilization is invaded by Astronaut Chuck Baker, who believes that the planet was uninhabited. Wanted by the military, Baker must get back to his ship before it goes into orbit without him.",
                        91,
                        "Planet 51",
                        2009
                    },
                    {
                        15,
                        "Joseph Gordon-Levitt, Bruce Willis, Emily Blunt, Paul Dano",
                        "Rian Johnson",
                        "Action,Crime,Drama",
                        "http=//ia.media-imdb.com/images/M/MV5BMTY3NTY0MjEwNV5BMl5BanBnXkFtZTcwNTE3NDA1OA@@._V1_SX300.jpg",
                        "In 2074, when the mob wants to get rid of someone, the target is sent into the past, where a hired gun awaits - someone like Joe - who one day learns the mob wants to 'close the loop' by sending back Joe's future self for assassination.",
                        119,
                        "Looper",
                        2012
                    },
                    {
                        16,
                        "Johnny Depp, Helena Bonham Carter, Emily Watson, Tracey Ullman",
                        "Tim Burton, Mike Johnson",
                        "Animation,Drama,Family",
                        "http=//ia.media-imdb.com/images/M/MV5BMTk1MTY1NjU4MF5BMl5BanBnXkFtZTcwNjIzMTEzMw@@._V1_SX300.jpg",
                        "When a shy groom practices his wedding vows in the inadvertent presence of a deceased young woman, she rises from the grave assuming he has married her.",
                        77,
                        "Corpse Bride",
                        2005
                    },
                    {
                        17,
                        "Joseph Cotten, Alida Valli, Orson Welles, Trevor Howard",
                        "Carol Reed",
                        "Film-Noir,Mystery,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjMwNzMzMTQ0Ml5BMl5BanBnXkFtZTgwNjExMzUwNjE@._V1_SX300.jpg",
                        "Pulp novelist Holly Martins travels to shadowy, postwar Vienna, only to find himself investigating the mysterious death of an old friend, Harry Lime.",
                        93,
                        "The Third Man",
                        1949
                    },
                    {
                        18,
                        "Leonardo DiCaprio, Daniel York, Patcharawan Patarakijjanon, Virginie Ledoyen",
                        "Danny Boyle",
                        "Adventure,Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BN2ViYTFiZmUtOTIxZi00YzIxLWEyMzUtYjQwZGNjMjNhY2IwXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg",
                        "Twenty-something Richard travels to Thailand and finds himself in possession of a strange map. Rumours state that it leads to a solitary beach paradise, a tropical bliss - excited and intrigued, he sets out to find it.",
                        119,
                        "The Beach",
                        2000
                    },
                    {
                        19,
                        "Al Pacino, Steven Bauer, Michelle Pfeiffer, Mary Elizabeth Mastrantonio",
                        "Brian De Palma",
                        "Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjAzOTM4MzEwNl5BMl5BanBnXkFtZTgwMzU1OTc1MDE@._V1_SX300.jpg",
                        "In Miami in 1980, a determined Cuban immigrant takes over a drug cartel and succumbs to greed.",
                        170,
                        "Scarface",
                        1983
                    },
                    {
                        20,
                        "Gary Oldman, Chloe Webb, David Hayman, Debby Bishop",
                        "Alex Cox",
                        "Biography,Drama,Music",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjExNjA5NzY4M15BMl5BanBnXkFtZTcwNjQ2NzI5NA@@._V1_SX300.jpg",
                        "Morbid biographical story of Sid Vicious, bassist with British punk group the Sex Pistols, and his girlfriend Nancy Spungen. When the Sex Pistols break up after their fateful US tour, ...",
                        112,
                        "Sid and Nancy",
                        1986
                    },
                    {
                        21,
                        "Natalie Portman, Mila Kunis, Vincent Cassel, Barbara Hershey",
                        "Darren Aronofsky",
                        "Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNzY2NzI4OTE5MF5BMl5BanBnXkFtZTcwMjMyNDY4Mw@@._V1_SX300.jpg",
                        "A committed dancer wins the lead role in a production of Tchaikovsky's 'Swan Lake' only to find herself struggling to maintain her sanity.",
                        108,
                        "Black Swan",
                        2010
                    },
                    {
                        22,
                        "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page, Tom Hardy",
                        "Christopher Nolan",
                        "Action,Adventure,Sci-Fi",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg",
                        "A thief, who steals corporate secrets through use of dream-sharing technology, is given the inverse task of planting an idea into the mind of a CEO.",
                        148,
                        "Inception",
                        2010
                    },
                    {
                        23,
                        "Robert De Niro, John Cazale, John Savage, Christopher Walken",
                        "Michael Cimino",
                        "Drama,War",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTYzYmRmZTQtYjk2NS00MDdlLTkxMDAtMTE2YTM2ZmNlMTBkXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                        "An in-depth examination of the ways in which the U.S. Vietnam War impacts and disrupts the lives of people in a small industrial town in Pennsylvania.",
                        183,
                        "The Deer Hunter",
                        1978
                    },
                    {
                        24,
                        "Ethan Suplee, Ben Affleck, Scott Mosier, Jason Lee",
                        "Kevin Smith",
                        "Comedy,Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BZDM3MTg2MGUtZDM0MC00NzMwLWE5NjItOWFjNjA2M2I4YzgxXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                        "Holden and Banky are comic book artists. Everything's going good for them until they meet Alyssa, also a comic book artist. Holden falls for her, but his hopes are crushed when he finds out she's gay.",
                        113,
                        "Chasing Amy",
                        1997
                    },
                    {
                        25,
                        "Jamie Foxx, Christoph Waltz, Leonardo DiCaprio, Kerry Washington",
                        "Quentin Tarantino",
                        "Drama,Western",
                        "http=//ia.media-imdb.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_SX300.jpg",
                        "With the help of a German bounty hunter, a freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.",
                        165,
                        "Django Unchained",
                        2012
                    },
                    {
                        26,
                        "Jodie Foster, Lawrence A. Bonney, Kasi Lemmons, Lawrence T. Wrentz",
                        "Jonathan Demme",
                        "Crime,Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQ2NzkzMDI4OF5BMl5BanBnXkFtZTcwMDA0NzE1NA@@._V1_SX300.jpg",
                        "A young F.B.I. cadet must confide in an incarcerated and manipulative killer to receive his help on catching another serial killer who skins his victims.",
                        118,
                        "The Silence of the Lambs",
                        1991
                    },
                    {
                        27,
                        "Kevin Spacey, Annette Bening, Thora Birch, Wes Bentley",
                        "Sam Mendes",
                        "Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjM4NTI5NzYyNV5BMl5BanBnXkFtZTgwNTkxNTYxMTE@._V1_SX300.jpg",
                        "A sexually frustrated suburban father has a mid-life crisis after becoming infatuated with his daughter's best friend.",
                        122,
                        "American Beauty",
                        1999
                    },
                    {
                        28,
                        "Benicio Del Toro, Dennis Farina, Vinnie Jones, Brad Pitt",
                        "Guy Ritchie",
                        "Comedy,Crime",
                        "http=//ia.media-imdb.com/images/M/MV5BMTA2NDYxOGYtYjU1Mi00Y2QzLTgxMTQtMWI1MGI0ZGQ5MmU4XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg",
                        "Unscrupulous boxing promoters, violent bookmakers, a Russian gangster, incompetent amateur robbers, and supposedly Jewish jewelers fight to track down a priceless stolen diamond.",
                        102,
                        "Snatch",
                        2000
                    },
                    {
                        29,
                        "Brad Davis, Irene Miracle, Bo Hopkins, Paolo Bonacelli",
                        "Alan Parker",
                        "Crime,Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQyMDA5MzkyOF5BMl5BanBnXkFtZTgwOTYwNTcxMTE@._V1_SX300.jpg",
                        "Billy Hayes, an American college student, is caught smuggling drugs out of Turkey and thrown into prison.",
                        121,
                        "Midnight Express",
                        1978
                    },
                    {
                        30,
                        "Tim Roth, Amanda Plummer, Laura Lovelace, John Travolta",
                        "Quentin Tarantino",
                        "Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTkxMTA5OTAzMl5BMl5BanBnXkFtZTgwNjA5MDc3NjE@._V1_SX300.jpg",
                        "The lives of two mob hit men, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                        154,
                        "Pulp Fiction",
                        1994
                    },
                    {
                        31,
                        "Jason Flemyng, Dexter Fletcher, Nick Moran, Jason Statham",
                        "Guy Ritchie",
                        "Comedy,Crime",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTAyN2JmZmEtNjAyMy00NzYwLThmY2MtYWQ3OGNhNjExMmM4XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg",
                        "A botched card game in London triggers four friends, thugs, weed-growers, hard gangsters, loan sharks and debt collectors to collide with each other in a series of unexpected events, all for the sake of weed, cash and two antique shotguns.",
                        107,
                        "Lock, Stock and Two Smoking Barrels",
                        1998
                    },
                    {
                        32,
                        "Josh Hartnett, Bruce Willis, Lucy Liu, Morgan Freeman",
                        "Paul McGuigan",
                        "Crime,Drama,Mystery",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMzc1OTEwMTk4OF5BMl5BanBnXkFtZTcwMTEzMDQzMQ@@._V1_SX300.jpg",
                        "A case of mistaken identity lands Slevin into the middle of a war being plotted by two of the city's most rival crime bosses= The Rabbi and The Boss. Slevin is under constant surveillance by relentless Detective Brikowski as well as the infamous assassin Goodkat and finds himself having to hatch his own ingenious plot to get them before they get him.",
                        110,
                        "Lucky Number Slevin",
                        2006
                    },
                    {
                        33,
                        "James Stewart, Grace Kelly, Wendell Corey, Thelma Ritter",
                        "Alfred Hitchcock",
                        "Mystery,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNGUxYWM3M2MtMGM3Mi00ZmRiLWE0NGQtZjE5ODI2OTJhNTU0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                        "A wheelchair-bound photographer spies on his neighbours from his apartment window and becomes convinced one of them has committed murder.",
                        112,
                        "Rear Window",
                        1954
                    },
                    {
                        34,
                        "Ivana Baquero, Sergi López, Maribel Verdú, Doug Jones",
                        "Guillermo del Toro",
                        "Drama,Fantasy,War",
                        "",
                        "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.",
                        118,
                        "Pan's Labyrinth",
                        2006
                    },
                    {
                        35,
                        "Leonardo DiCaprio, Mark Ruffalo, Ben Kingsley, Max von Sydow",
                        "Martin Scorsese",
                        "Mystery,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTMxMTIyNzMxMV5BMl5BanBnXkFtZTcwOTc4OTI3Mg@@._V1_SX300.jpg",
                        "In 1954, a U.S. marshal investigates the disappearance of a murderess who escaped from a hospital for the criminally insane.",
                        138,
                        "Shutter Island",
                        2010
                    },
                    {
                        36,
                        "Harvey Keitel, Tim Roth, Michael Madsen, Chris Penn",
                        "Quentin Tarantino",
                        "Crime,Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNjE5ZDJiZTQtOGE2YS00ZTc5LTk0OGUtOTg2NjdjZmVlYzE2XkEyXkFqcGdeQXVyMzM4MjM0Nzg@._V1_SX300.jpg",
                        "After a simple jewelry heist goes terribly wrong, the surviving criminals begin to suspect that one of them is a police informant.",
                        99,
                        "Reservoir Dogs",
                        1992
                    },
                    {
                        37,
                        "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers",
                        "Stanley Kubrick",
                        "Drama,Horror",
                        "http=//ia.media-imdb.com/images/M/MV5BODMxMjE3NTA4Ml5BMl5BanBnXkFtZTgwNDc0NTIxMDE@._V1_SX300.jpg",
                        "A family heads to an isolated hotel for the winter where an evil and spiritual presence influences the father into violence, while his psychic son sees horrific forebodings from the past and of the future.",
                        146,
                        "The Shining",
                        1980
                    },
                    {
                        38,
                        "Owen Wilson, Rachel McAdams, Kurt Fuller, Mimi Kennedy",
                        "Woody Allen",
                        "Comedy,Fantasy,Romance",
                        "http=//ia.media-imdb.com/images/M/MV5BMTM4NjY1MDQwMl5BMl5BanBnXkFtZTcwNTI3Njg3NA@@._V1_SX300.jpg",
                        "While on a trip to Paris with his fiancée's family, a nostalgic screenwriter finds himself mysteriously going back to the 1920s everyday at midnight.",
                        94,
                        "Midnight in Paris",
                        2011
                    },
                    {
                        39,
                        "Hugh Jackman, Russell Crowe, Anne Hathaway, Amanda Seyfried",
                        "Tom Hooper",
                        "Drama,Musical,Romance",
                        "http=//ia.media-imdb.com/images/M/MV5BMTQ4NDI3NDg4M15BMl5BanBnXkFtZTcwMjY5OTI1OA@@._V1_SX300.jpg",
                        "In 19th-century France, Jean Valjean, who for decades has been hunted by the ruthless policeman Javert after breaking parole, agrees to care for a factory worker's daughter. The decision changes their lives forever.",
                        158,
                        "Les Misérables",
                        2012
                    },
                    {
                        40,
                        "Kevin Spacey, Russell Crowe, Guy Pearce, James Cromwell",
                        "Curtis Hanson",
                        "Crime,Drama,Mystery",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNWEwNDhhNWUtYWMzNi00ZTNhLWFiZDAtMjBjZmJhMTU0ZTY2XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg",
                        "As corruption grows in 1950s LA, three policemen - one strait-laced, one brutal, and one sleazy - investigate a series of murders with their own brand of justice.",
                        138,
                        "L.A. Confidential",
                        1997
                    },
                    {
                        41,
                        "Brad Pitt, Jonah Hill, Philip Seymour Hoffman, Robin Wright",
                        "Bennett Miller",
                        "Biography,Drama,Sport",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjAxOTU3Mzc1M15BMl5BanBnXkFtZTcwMzk1ODUzNg@@._V1_SX300.jpg",
                        "Oakland A's general manager Billy Beane's successful attempt to assemble a baseball team on a lean budget by employing computer-generated analysis to acquire new players.",
                        133,
                        "Moneyball",
                        2011
                    },
                    {
                        42,
                        "Bradley Cooper, Ed Helms, Zach Galifianakis, Justin Bartha",
                        "Todd Phillips",
                        "Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU1MDA1MTYwMF5BMl5BanBnXkFtZTcwMDcxMzA1Mg@@._V1_SX300.jpg",
                        "Three buddies wake up from a bachelor party in Las Vegas, with no memory of the previous night and the bachelor missing. They make their way around the city in order to find their friend before his wedding.",
                        100,
                        "The Hangover",
                        2009
                    },
                    {
                        43,
                        "Toni Servillo, Carlo Verdone, Sabrina Ferilli, Carlo Buccirosso",
                        "Paolo Sorrentino",
                        "Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQ0ODg1OTQ2Nl5BMl5BanBnXkFtZTgwNTc2MDY1MDE@._V1_SX300.jpg",
                        "Jep Gambardella has seduced his way through the lavish nightlife of Rome for decades, but after his 65th birthday and a shock from the past, Jep looks past the nightclubs and parties to find a timeless landscape of absurd, exquisite beauty.",
                        141,
                        "The Great Beauty",
                        2013
                    },
                    {
                        44,
                        "Clint Eastwood, Christopher Carley, Bee Vang, Ahney Her",
                        "Clint Eastwood",
                        "Drama",
                        "http=//ia.media-imdb.com/images/M/MV5BMTQyMTczMTAxMl5BMl5BanBnXkFtZTcwOTc1ODE0Mg@@._V1_SX300.jpg",
                        "Disgruntled Korean War veteran Walt Kowalski sets out to reform his neighbor, a Hmong teenager who tried to steal Kowalski's prized possession= a 1972 Gran Torino.",
                        116,
                        "Gran Torino",
                        2008
                    },
                    {
                        45,
                        "Toni Collette, Philip Seymour Hoffman, Barry Humphries, Eric Bana",
                        "Adam Elliot",
                        "Animation,Comedy,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQ1NDIyNTA1Nl5BMl5BanBnXkFtZTcwMjc2Njk3OA@@._V1_SX300.jpg",
                        "A tale of friendship between two unlikely pen pals= Mary, a lonely, eight-year-old girl living in the suburbs of Melbourne, and Max, a forty-four-year old, severely obese man living in New York.",
                        92,
                        "Mary and Max",
                        2009
                    },
                    {
                        46,
                        "Nadine Velazquez, Denzel Washington, Carter Cabassa, Adam C. Edwards",
                        "Robert Zemeckis",
                        "Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTUxMjI1OTMxNl5BMl5BanBnXkFtZTcwNjc3NTY1OA@@._V1_SX300.jpg",
                        "An airline pilot saves almost all his passengers on his malfunctioning airliner which eventually crashed, but an investigation into the accident reveals something troubling.",
                        138,
                        "Flight",
                        2012
                    },
                    {
                        47,
                        "Michael Berryman, Peter Brocco, Dean R. Brooks, Alonzo Brown",
                        "Milos Forman",
                        "Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BYmJkODkwOTItZThjZC00MTE0LWIxNzQtYTM3MmQwMGI1OWFiXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_SX300.jpg",
                        "A criminal pleads insanity after getting into trouble again and once in the mental institution rebels against the oppressive nurse and rallies up the scared patients.",
                        133,
                        "One Flew Over the Cuckoo's Nest",
                        1975
                    },
                    {
                        48,
                        "Ellen Burstyn, Jared Leto, Jennifer Connelly, Marlon Wayans",
                        "Darren Aronofsky",
                        "Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTkzODMzODYwOF5BMl5BanBnXkFtZTcwODM2NjA2NQ@@._V1_SX300.jpg",
                        "The drug-induced utopias of four Coney Island people are shattered when their addictions run deep.",
                        102,
                        "Requiem for a Dream",
                        2000
                    },
                    {
                        49,
                        "Jim Carrey, Laura Linney, Noah Emmerich, Natascha McElhone",
                        "Peter Weir",
                        "Comedy,Drama,Sci-Fi",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMDIzODcyY2EtMmY2MC00ZWVlLTgwMzAtMjQwOWUyNmJjNTYyXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg",
                        "An insurance salesman/adjuster discovers his entire life is actually a television show.",
                        103,
                        "The Truman Show",
                        1998
                    },
                    {
                        50,
                        "Jean Dujardin, Bérénice Bejo, John Goodman, James Cromwell",
                        "Michel Hazanavicius",
                        "Comedy,Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMzk0NzQxMTM0OV5BMl5BanBnXkFtZTcwMzU4MDYyNQ@@._V1_SX300.jpg",
                        "A silent movie star meets a young dancer, but the arrival of talking pictures sends their careers in opposite directions.",
                        100,
                        "The Artist",
                        2011
                    },
                    {
                        51,
                        "Tom Hanks, Rebecca Williams, Sally Field, Michael Conner Humphreys",
                        "Robert Zemeckis",
                        "Comedy,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BYThjM2MwZGMtMzg3Ny00NGRkLWE4M2EtYTBiNWMzOTY0YTI4XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_SX300.jpg",
                        "Forrest Gump, while not intelligent, has accidentally been present at many historic moments, but his true love, Jenny Curran, eludes him.",
                        142,
                        "Forrest Gump",
                        1994
                    },
                    {
                        52,
                        "Ian McKellen, Martin Freeman, Richard Armitage, Ken Stott",
                        "Peter Jackson",
                        "Adventure,Fantasy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMzU0NDY0NDEzNV5BMl5BanBnXkFtZTgwOTIxNDU1MDE@._V1_SX300.jpg",
                        "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug. Bilbo Baggins is in possession of a mysterious and magical ring.",
                        161,
                        "The Hobbit= The Desolation of Smaug",
                        2013
                    },
                    {
                        53,
                        "Rebecca Hall, Scarlett Johansson, Christopher Evan Welch, Chris Messina",
                        "Woody Allen",
                        "Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU2NDQ4MTg2MV5BMl5BanBnXkFtZTcwNDUzNjU3MQ@@._V1_SX300.jpg",
                        "Two girlfriends on a summer holiday in Spain become enamored with the same painter, unaware that his ex-wife, with whom he has a tempestuous relationship, is about to re-enter the picture.",
                        96,
                        "Vicky Cristina Barcelona",
                        2008
                    },
                    {
                        54,
                        "Dev Patel, Saurabh Shukla, Anil Kapoor, Rajendranath Zutshi",
                        "Danny Boyle, Loveleen Tandan",
                        "Drama,Romance",
                        "http=//ia.media-imdb.com/images/M/MV5BMTU2NTA5NzI0N15BMl5BanBnXkFtZTcwMjUxMjYxMg@@._V1_SX300.jpg",
                        "A Mumbai teen reflects on his upbringing in the slums when he is accused of cheating on the Indian Version of 'Who Wants to be a Millionaire?'",
                        120,
                        "Slumdog Millionaire",
                        2008
                    },
                    {
                        55,
                        "Scarlett Johansson, Bill Murray, Akiko Takeshita, Kazuyoshi Minamimagoe",
                        "Sofia Coppola",
                        "Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTI2NDI5ODk4N15BMl5BanBnXkFtZTYwMTI3NTE3._V1_SX300.jpg",
                        "A faded movie star and a neglected young woman form an unlikely bond after crossing paths in Tokyo.",
                        101,
                        "Lost in Translation",
                        2003
                    },
                    {
                        56,
                        "Jonathan Rhys Meyers, Alexander Armstrong, Paul Kaye, Matthew Goode",
                        "Woody Allen",
                        "Drama,Romance,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTMzNzY4MzE5NF5BMl5BanBnXkFtZTcwMzQ1MDMzMQ@@._V1_SX300.jpg",
                        "At a turning point in his life, a former tennis pro falls for an actress who happens to be dating his friend and soon-to-be brother-in-law.",
                        119,
                        "Match Point",
                        2005
                    },
                    {
                        57,
                        "Anthony Perkins, Vera Miles, John Gavin, Janet Leigh",
                        "Alfred Hitchcock",
                        "Horror,Mystery,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMDI3OWRmOTEtOWJhYi00N2JkLTgwNGItMjdkN2U0NjFiZTYwXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                        "A Phoenix secretary embezzles $40,000 from her employer's client, goes on the run, and checks into a remote motel run by a young man under the domination of his mother.",
                        109,
                        "Psycho",
                        1960
                    },
                    {
                        58,
                        "Cary Grant, Eva Marie Saint, James Mason, Jessie Royce Landis",
                        "Alfred Hitchcock",
                        "Action,Adventure,Crime",
                        "http=//ia.media-imdb.com/images/M/MV5BMjQwMTQ0MzgwNl5BMl5BanBnXkFtZTgwNjc4ODE4MzE@._V1_SX300.jpg",
                        "A hapless New York advertising executive is mistaken for a government agent by a group of foreign spies, and is pursued across the country while he looks for a way to survive.",
                        136,
                        "North by Northwest",
                        1959
                    },
                    {
                        59,
                        "Ben Stiller, Chris Rock, David Schwimmer, Jada Pinkett Smith",
                        "Eric Darnell, Tom McGrath",
                        "Animation,Action,Adventure",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjExMDA4NDcwMl5BMl5BanBnXkFtZTcwODAxNTQ3MQ@@._V1_SX300.jpg",
                        "The animals try to fly back to New York City, but crash-land on an African wildlife refuge, where Alex is reunited with his parents.",
                        89,
                        "Madagascar= Escape 2 Africa",
                        2008
                    },
                    {
                        60,
                        "Steve Carell, Kristen Wiig, Benjamin Bratt, Miranda Cosgrove",
                        "Pierre Coffin, Chris Renaud",
                        "Animation,Adventure,Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjExNjAyNTcyMF5BMl5BanBnXkFtZTgwODQzMjQ3MDE@._V1_SX300.jpg",
                        "When Gru, the world's most super-bad turned super-dad has been recruited by a team of officials to stop lethal muscle and a host of Gru's own, He has to fight back with new gadgetry, cars, and more minion madness.",
                        98,
                        "Despicable Me 2",
                        2013
                    },
                    {
                        61,
                        "Bruno Ganz, Alexandra Maria Lara, Corinna Harfouch, Ulrich Matthes",
                        "Oliver Hirschbiegel",
                        "Biography,Drama,History",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM1OTI1MjE2Nl5BMl5BanBnXkFtZTcwMTEwMzc4NA@@._V1_SX300.jpg",
                        "Traudl Junge, the final secretary for Adolf Hitler, tells of the Nazi dictator's final days in his Berlin bunker at the end of WWII.",
                        156,
                        "Downfall",
                        2004
                    },
                    {
                        62,
                        "Ben Stiller, Chris Rock, David Schwimmer, Jada Pinkett Smith",
                        "Eric Darnell, Tom McGrath",
                        "Animation,Adventure,Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY4NDUwMzQxMF5BMl5BanBnXkFtZTcwMDgwNjgyMQ@@._V1_SX300.jpg",
                        "Spoiled by their upbringing with no idea what wild life is really like, four animals from New York Central Zoo escape, unwittingly assisted by four absconding penguins, and find themselves in Madagascar, among a bunch of merry lemurs",
                        86,
                        "Madagascar",
                        2005
                    },
                    {
                        63,
                        "Ben Stiller, Chris Rock, David Schwimmer, Jada Pinkett Smith",
                        "Eric Darnell, Tom McGrath, Conrad Vernon",
                        "Animation,Adventure,Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM2MTIzNzk2MF5BMl5BanBnXkFtZTcwMDcwMzQxNw@@._V1_SX300.jpg",
                        "Alex, Marty, Gloria and Melman are still fighting to get home to their beloved Big Apple. Their journey takes them through Europe where they find the perfect cover= a traveling circus, which they reinvent - Madagascar style.",
                        93,
                        "Madagascar 3= Europe's Most Wanted",
                        2012
                    },
                    {
                        64,
                        "Joel Murray, Tara Lynne Barr, Melinda Page Hamilton, Mackenzie Brooke Smith",
                        "Bobcat Goldthwait",
                        "Comedy,Crime",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQwMTc1MzA4NF5BMl5BanBnXkFtZTcwNzQwMTgzNw@@._V1_SX300.jpg",
                        "On a mission to rid society of its most repellent citizens, terminally ill Frank makes an unlikely accomplice in 16-year-old Roxy.",
                        105,
                        "God Bless America",
                        2011
                    },
                    {
                        65,
                        "Jesse Eisenberg, Rooney Mara, Bryan Barter, Dustin Fitzsimons",
                        "David Fincher",
                        "Biography,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM2ODk0NDAwMF5BMl5BanBnXkFtZTcwNTM1MDc2Mw@@._V1_SX300.jpg",
                        "Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, but is later sued by two brothers who claimed he stole their idea, and the co-founder who was later squeezed out of the business.",
                        120,
                        "The Social Network",
                        2010
                    },
                    {
                        66,
                        "Adrien Brody, Emilia Fox, Michal Zebrowski, Ed Stoppard",
                        "Roman Polanski",
                        "Biography,Drama,War",
                        "http=//ia.media-imdb.com/images/M/MV5BMTc4OTkyOTA3OF5BMl5BanBnXkFtZTYwMDIxNjk5._V1_SX300.jpg",
                        "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II.",
                        150,
                        "The Pianist",
                        2002
                    },
                    {
                        67,
                        "Ethan Hawke, Vincent Spano, Josh Hamilton, Bruce Ramsay",
                        "Frank Marshall",
                        "Adventure,Biography,Drama",
                        "",
                        "Uruguayan rugby team stranded in the snow swept Andes are forced to use desperate measures to survive after a plane crash.",
                        120,
                        "Alive",
                        1993
                    },
                    {
                        68,
                        "Humphrey Bogart, Ingrid Bergman, Paul Henreid, Claude Rains",
                        "Michael Curtiz",
                        "Drama,Romance,War",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjQwNDYyNTk2N15BMl5BanBnXkFtZTgwMjQ0OTMyMjE@._V1_SX300.jpg",
                        "In Casablanca, Morocco in December 1941, a cynical American expatriate meets a former lover, with unforeseen complications.",
                        102,
                        "Casablanca",
                        1942
                    },
                    {
                        69,
                        "Denzel Washington, Russell Crowe, Chiwetel Ejiofor, Josh Brolin",
                        "Ridley Scott",
                        "Biography,Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTkyNzY5MDA5MV5BMl5BanBnXkFtZTcwMjg4MzI3MQ@@._V1_SX300.jpg",
                        "In 1970s America, a detective works to bring down the drug empire of Frank Lucas, a heroin kingpin from Manhattan, who is smuggling the drug into the country from the Far East.",
                        157,
                        "American Gangster",
                        2007
                    },
                    {
                        70,
                        "Leonardo DiCaprio, Tom Hanks, Christopher Walken, Martin Sheen",
                        "Steven Spielberg",
                        "Biography,Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY5MzYzNjc5NV5BMl5BanBnXkFtZTYwNTUyNTc2._V1_SX300.jpg",
                        "The true story of Frank Abagnale Jr. who, before his 19th birthday, successfully conned millions of dollars' worth of checks as a Pan Am pilot, doctor, and legal prosecutor.",
                        141,
                        "Catch Me If You Can",
                        2002
                    },
                    {
                        71,
                        "Edward Norton, Edward Furlong, Beverly D'Angelo, Jennifer Lien",
                        "Tony Kaye",
                        "Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BZjA0MTM4MTQtNzY5MC00NzY3LWI1ZTgtYzcxMjkyMzU4MDZiXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_SX300.jpg",
                        "A former neo-nazi skinhead tries to prevent his younger brother from going down the same wrong path that he did.",
                        119,
                        "American History X",
                        1998
                    },
                    {
                        72,
                        "Robert De Niro, Sharon Stone, Joe Pesci, James Woods",
                        "Martin Scorsese",
                        "Biography,Crime,Drama",
                        "http=//ia.media-imdb.com/images/M/MV5BMTcxOWYzNDYtYmM4YS00N2NkLTk0NTAtNjg1ODgwZjAxYzI3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SX300.jpg",
                        "Greed, deception, money, power, and murder occur between two best friends, a mafia underboss and a casino owner, for a trophy wife over a gambling empire.",
                        178,
                        "Casino",
                        1995
                    },
                    {
                        73,
                        "Johnny Depp, Geoffrey Rush, Orlando Bloom, Keira Knightley",
                        "Gore Verbinski",
                        "Action,Adventure,Fantasy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjIyNjkxNzEyMl5BMl5BanBnXkFtZTYwMjc3MDE3._V1_SX300.jpg",
                        "Captain Barbossa, Will Turner and Elizabeth Swann must sail off the edge of the map, navigate treachery and betrayal, find Jack Sparrow, and make their final alliances for one last decisive battle.",
                        169,
                        "Pirates of the Caribbean= At World's End",
                        2007
                    },
                    {
                        74,
                        "Johnny Depp, Penélope Cruz, Geoffrey Rush, Ian McShane",
                        "Rob Marshall",
                        "Action,Adventure,Fantasy",
                        "http=//ia.media-imdb.com/images/M/MV5BMjE5MjkwODI3Nl5BMl5BanBnXkFtZTcwNjcwMDk4NA@@._V1_SX300.jpg",
                        "Jack Sparrow and Barbossa embark on a quest to find the elusive fountain of youth, only to discover that Blackbeard and his daughter are after it too.",
                        136,
                        "Pirates of the Caribbean= On Stranger Tides",
                        2011
                    },
                    {
                        75,
                        "Karina Arroyave, Dato Bakhtadze, Sandra Bullock, Don Cheadle",
                        "Paul Haggis",
                        "Crime,Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BOTk1OTA1MjIyNV5BMl5BanBnXkFtZTcwODQxMTkyMQ@@._V1_SX300.jpg",
                        "Los Angeles citizens with vastly separate lives collide in interweaving stories of race, loss and redemption.",
                        112,
                        "Crash",
                        2004
                    },
                    {
                        76,
                        "Johnny Depp, Geoffrey Rush, Orlando Bloom, Keira Knightley",
                        "Gore Verbinski",
                        "Action,Adventure,Fantasy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjAyNDM4MTc2N15BMl5BanBnXkFtZTYwNDk0Mjc3._V1_SX300.jpg",
                        "Blacksmith Will Turner teams up with eccentric pirate 'Captain' Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.",
                        143,
                        "Pirates of the Caribbean= The Curse of the Black Pearl",
                        2003
                    },
                    {
                        77,
                        "Noel Appleby, Ali Astin, Sean Astin, David Aston",
                        "Peter Jackson",
                        "Action,Adventure,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjE4MjA1NTAyMV5BMl5BanBnXkFtZTcwNzM1NDQyMQ@@._V1_SX300.jpg",
                        "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                        201,
                        "The Lord of the Rings= The Return of the King",
                        2003
                    },
                    {
                        78,
                        "Min-sik Choi, Ji-tae Yu, Hye-jeong Kang, Dae-han Ji",
                        "Chan-wook Park",
                        "Drama,Mystery,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTI3NTQyMzU5M15BMl5BanBnXkFtZTcwMTM2MjgyMQ@@._V1_SX300.jpg",
                        "After being kidnapped and imprisoned for 15 years, Oh Dae-Su is released, only to find that he must find his captor in 5 days.",
                        120,
                        "Oldboy",
                        2003
                    },
                    {
                        79,
                        "Alfred Molina, Carrie-Anne Moss, Aurelien Parent Koenig, Antonio Gil",
                        "Lasse Hallström",
                        "Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA4MDI3NTQwMV5BMl5BanBnXkFtZTcwNjIzNDcyMQ@@._V1_SX300.jpg",
                        "A woman and her daughter open a chocolate shop in a small French village that shakes up the rigid morality of the community.",
                        121,
                        "Chocolat",
                        2000
                    },
                    {
                        80,
                        "Daniel Craig, Eva Green, Mads Mikkelsen, Judi Dench",
                        "Martin Campbell",
                        "Action,Adventure,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM5MjI4NDExNF5BMl5BanBnXkFtZTcwMDM1MjMzMQ@@._V1_SX300.jpg",
                        "Armed with a licence to kill, Secret Agent James Bond sets out on his first mission as 007 and must defeat a weapons dealer in a high stakes game of poker at Casino Royale, but things are not what they seem.",
                        144,
                        "Casino Royale",
                        2006
                    },
                    {
                        81,
                        "Ben Burtt, Elissa Knight, Jeff Garlin, Fred Willard",
                        "Andrew Stanton",
                        "Animation,Adventure,Family",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTczOTA3MzY2N15BMl5BanBnXkFtZTcwOTYwNjE2MQ@@._V1_SX300.jpg",
                        "In the distant future, a small waste-collecting robot inadvertently embarks on a space journey that will ultimately decide the fate of mankind.",
                        98,
                        "WALL·E",
                        2008
                    },
                    {
                        82,
                        "Leonardo DiCaprio, Jonah Hill, Margot Robbie, Matthew McConaughey",
                        "Martin Scorsese",
                        "Biography,Comedy,Crime",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_SX300.jpg",
                        "Based on the true story of Jordan Belfort, from his rise to a wealthy stock-broker living the high life to his fall involving crime, corruption and the federal government.",
                        180,
                        "The Wolf of Wall Street",
                        2013
                    },
                    {
                        83,
                        "Ron Perlman, Selma Blair, Doug Jones, John Alexander",
                        "Guillermo del Toro",
                        "Action,Adventure,Fantasy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA5NzgyMjc2Nl5BMl5BanBnXkFtZTcwOTU3MDI3MQ@@._V1_SX300.jpg",
                        "The mythical world starts a rebellion against humanity in order to rule the Earth, so Hellboy and his team must save the world from the rebellious creatures.",
                        120,
                        "Hellboy II= The Golden Army",
                        2008
                    },
                    {
                        84,
                        "William Holden, Gloria Swanson, Erich von Stroheim, Nancy Olson",
                        "Billy Wilder",
                        "Drama,Film-Noir,Romance",
                        "http=//ia.media-imdb.com/images/M/MV5BMTc3NDYzODAwNV5BMl5BanBnXkFtZTgwODg1MTczMTE@._V1_SX300.jpg",
                        "A hack screenwriter writes a screenplay for a former silent-film star who has faded into Hollywood obscurity.",
                        110,
                        "Sunset Boulevard",
                        1950
                    },
                    {
                        85,
                        "Beau Bridges, Rosanna Arquette, Mathew Botuchis, Shiri Appleby",
                        "Eric Steven Stahl",
                        "Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTYwMDUzNzA5Nl5BMl5BanBnXkFtZTcwMjQ2Njk3MQ@@._V1_SX300.jpg",
                        "A 17-year-old boy buys mini-cameras and displays the footage online at I-see-you.com. The cash rolls in as the site becomes a major hit. Everyone seems to have fun until it all comes crashing down....",
                        92,
                        "I-See-You.Com",
                        2006
                    },
                    {
                        86,
                        "Ralph Fiennes, F. Murray Abraham, Mathieu Amalric, Adrien Brody",
                        "Wes Anderson",
                        "Adventure,Comedy,Crime",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMzM5NjUxOTEyMl5BMl5BanBnXkFtZTgwNjEyMDM0MDE@._V1_SX300.jpg",
                        "The adventures of Gustave H, a legendary concierge at a famous hotel from the fictional Republic of Zubrowka between the first and second World Wars, and Zero Moustafa, the lobby boy who becomes his most trusted friend.",
                        99,
                        "The Grand Budapest Hotel",
                        2014
                    },
                    {
                        87,
                        "Bill Bailey, Anna Chancellor, Warwick Davis, Yasiin Bey",
                        "Garth Jennings",
                        "Adventure,Comedy,Sci-Fi",
                        "http=//ia.media-imdb.com/images/M/MV5BMjEwOTk4NjU2MF5BMl5BanBnXkFtZTYwMDA3NzI3._V1_SX300.jpg",
                        "Mere seconds before the Earth is to be demolished by an alien construction crew, journeyman Arthur Dent is swept off the planet by his friend Ford Prefect, a researcher penning a new edition of 'The Hitchhiker's Guide to the Galaxy.'",
                        109,
                        "The Hitchhiker's Guide to the Galaxy",
                        2005
                    },
                    {
                        88,
                        "Robert De Niro, James Woods, Elizabeth McGovern, Joe Pesci",
                        "Sergio Leone",
                        "Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMGFkNWI4MTMtNGQ0OC00MWVmLTk3MTktOGYxN2Y2YWVkZWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                        "A former Prohibition-era Jewish gangster returns to the Lower East Side of Manhattan over thirty years later, where he once again must confront the ghosts and regrets of his old life.",
                        229,
                        "Once Upon a Time in America",
                        1984
                    },
                    {
                        89,
                        "Tom Cruise, Morgan Freeman, Olga Kurylenko, Andrea Riseborough",
                        "Joseph Kosinski",
                        "Action,Adventure,Mystery",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQwMDY0MTA4MF5BMl5BanBnXkFtZTcwNzI3MDgxOQ@@._V1_SX300.jpg",
                        "A veteran assigned to extract Earth's remaining resources begins to question what he knows about his mission and himself.",
                        124,
                        "Oblivion",
                        2013
                    },
                    {
                        90,
                        "Natalie Portman, Hugo Weaving, Stephen Rea, Stephen Fry",
                        "James McTeigue",
                        "Action,Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BOTI5ODc3NzExNV5BMl5BanBnXkFtZTcwNzYxNzQzMw@@._V1_SX300.jpg",
                        "In a future British tyranny, a shadowy freedom fighter, known only by the alias of 'V', plots to overthrow it with the help of a young woman.",
                        132,
                        "V for Vendetta",
                        2005
                    },
                    {
                        91,
                        "Ethan Hawke, Uma Thurman, Gore Vidal, Xander Berkeley",
                        "Andrew Niccol",
                        "Drama,Sci-Fi,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNDQxOTc0MzMtZmRlOS00OWQ5LWI2ZDctOTAwNmMwOTYxYzlhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                        "A genetically inferior man assumes the identity of a superior one in order to pursue his lifelong dream of space travel.",
                        106,
                        "Gattaca",
                        1997
                    },
                    {
                        92,
                        "Bradley Cooper, Jennifer Lawrence, Robert De Niro, Jacki Weaver",
                        "David O. Russell",
                        "Comedy,Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM2MTI5NzA3MF5BMl5BanBnXkFtZTcwODExNTc0OA@@._V1_SX300.jpg",
                        "After a stint in a mental institution, former teacher Pat Solitano moves back in with his parents and tries to reconcile with his ex-wife. Things get more challenging when Pat meets Tiffany, a mysterious girl with problems of her own.",
                        122,
                        "Silver Linings Playbook",
                        2012
                    },
                    {
                        93,
                        "Johnny Depp, Mia Wasikowska, Helena Bonham Carter, Anne Hathaway",
                        "Tim Burton",
                        "Adventure,Family,Fantasy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTMwNjAxMTc0Nl5BMl5BanBnXkFtZTcwODc3ODk5Mg@@._V1_SX300.jpg",
                        "Nineteen-year-old Alice returns to the magical world from her childhood adventure, where she reunites with her old friends and learns of her true destiny= to end the Red Queen's reign of terror.",
                        108,
                        "Alice in Wonderland",
                        2010
                    },
                    {
                        94,
                        "Ben Kingsley, Candice Bergen, Edward Fox, John Gielgud",
                        "Richard Attenborough",
                        "Biography,Drama",
                        "http=//ia.media-imdb.com/images/M/MV5BMzJiZDRmOWUtYjE2MS00Mjc1LTg1ZDYtNTQxYWJkZTg1OTM4XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_SX300.jpg",
                        "Gandhi's character is fully explained as a man of nonviolence. Through his patience, he is able to drive the British out of the subcontinent. And the stubborn nature of Jinnah and his commitment towards Pakistan is portrayed.",
                        191,
                        "Gandhi",
                        1982
                    },
                    {
                        95,
                        "Charlie Hunnam, Diego Klattenhoff, Idris Elba, Rinko Kikuchi",
                        "Guillermo del Toro",
                        "Action,Adventure,Sci-Fi",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY3MTI5NjQ4Nl5BMl5BanBnXkFtZTcwOTU1OTU0OQ@@._V1_SX300.jpg",
                        "As a war between humankind and monstrous sea creatures wages on, a former pilot and a trainee are paired up to drive a seemingly obsolete special weapon in a desperate effort to save the world from the apocalypse.",
                        131,
                        "Pacific Rim",
                        2013
                    },
                    {
                        96,
                        "Robert Downey Jr., Val Kilmer, Michelle Monaghan, Corbin Bernsen",
                        "Shane Black",
                        "Comedy,Crime,Mystery",
                        "http=//ia.media-imdb.com/images/M/MV5BMTY5NDExMDA3M15BMl5BanBnXkFtZTYwNTc2MzA3._V1_SX300.jpg",
                        "A murder mystery brings together a private eye, a struggling actress, and a thief masquerading as an actor.",
                        103,
                        "Kiss Kiss Bang Bang",
                        2005
                    },
                    {
                        97,
                        "Michael Caine, Brendan Fraser, Do Thi Hai Yen, Rade Serbedzija",
                        "Phillip Noyce",
                        "Drama,Mystery,Romance",
                        "http=//ia.media-imdb.com/images/M/MV5BMjE2NTUxNTE3Nl5BMl5BanBnXkFtZTYwNTczMTg5._V1_SX300.jpg",
                        "An older British reporter vies with a young U.S. doctor for the affections of a beautiful Vietnamese woman.",
                        101,
                        "The Quiet American",
                        2002
                    },
                    {
                        98,
                        "Tom Hanks, Halle Berry, Jim Broadbent, Hugo Weaving",
                        "Tom Tykwer, Lana Wachowski, Lilly Wachowski",
                        "Drama,Sci-Fi",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTczMTgxMjc4NF5BMl5BanBnXkFtZTcwNjM5MTA2OA@@._V1_SX300.jpg",
                        "An exploration of how the actions of individual lives impact one another in the past, present and future, as one soul is shaped from a killer into a hero, and an act of kindness ripples across centuries to inspire a revolution.",
                        172,
                        "Cloud Atlas",
                        2012
                    },
                    {
                        99,
                        "Naomi Watts, Ewan McGregor, Tom Holland, Samuel Joslin",
                        "J.A. Bayona",
                        "Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA5NTA3NzQ5Nl5BMl5BanBnXkFtZTcwOTYxNjY0OA@@._V1_SX300.jpg",
                        "The story of a tourist family in Thailand caught in the destruction and chaotic aftermath of the 2004 Indian Ocean tsunami.",
                        114,
                        "The Impossible",
                        2012
                    },
                    {
                        100,
                        "Louis Wolheim, Lew Ayres, John Wray, Arnold Lucy",
                        "Lewis Milestone",
                        "Drama,War",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNTM5OTg2NDY1NF5BMl5BanBnXkFtZTcwNTQ4MTMwNw@@._V1_SX300.jpg",
                        "A young soldier faces profound disillusionment in the soul-destroying horror of World War I.",
                        136,
                        "All Quiet on the Western Front",
                        1930
                    },
                    {
                        101,
                        "Ralph Fiennes, Juliette Binoche, Willem Dafoe, Kristin Scott Thomas",
                        "Anthony Minghella",
                        "Drama,Romance,War",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNDg2OTcxNDE0OF5BMl5BanBnXkFtZTgwOTg2MDM0MDE@._V1_SX300.jpg",
                        "At the close of WWII, a young nurse tends to a badly-burned plane crash victim. His past is shown in flashbacks, revealing an involvement in a fateful love affair.",
                        162,
                        "The English Patient",
                        1996
                    },
                    {
                        102,
                        "Matthew McConaughey, Jennifer Garner, Jared Leto, Denis O'Hare",
                        "Jean-Marc Vallée",
                        "Biography,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTYwMTA4MzgyNF5BMl5BanBnXkFtZTgwMjEyMjE0MDE@._V1_SX300.jpg",
                        "In 1985 Dallas, electrician and hustler Ron Woodroof works around the system to help AIDS patients get the medication they need after he is diagnosed with the disease.",
                        117,
                        "Dallas Buyers Club",
                        2013
                    },
                    {
                        103,
                        "Salma Hayek, Mía Maestro, Alfred Molina, Antonio Banderas",
                        "Julie Taymor",
                        "Biography,Drama,Romance",
                        "http=//ia.media-imdb.com/images/M/MV5BMTMyODUyMDY1OV5BMl5BanBnXkFtZTYwMDA2OTU3._V1_SX300.jpg",
                        "A biography of artist Frida Kahlo, who channeled the pain of a crippling injury and her tempestuous marriage into her work.",
                        123,
                        "Frida",
                        2002
                    },
                    {
                        104,
                        "Ethan Hawke, Julie Delpy, Andrea Eckert, Hanno Pöschl",
                        "Richard Linklater",
                        "Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTQyMTM3MTQxMl5BMl5BanBnXkFtZTcwMDAzNjQ4Mg@@._V1_SX300.jpg",
                        "A young man and woman meet on a train in Europe, and wind up spending one evening together in Vienna. Unfortunately, both know that this will probably be their only night together.",
                        105,
                        "Before Sunrise",
                        1995
                    },
                    {
                        105,
                        "Johnny Depp, Aaron Eckhart, Michael Rispoli, Amber Heard",
                        "Bruce Robinson",
                        "Comedy,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM5ODA4MjYxM15BMl5BanBnXkFtZTcwMTM3NTE5Ng@@._V1_SX300.jpg",
                        "American journalist Paul Kemp takes on a freelance job in Puerto Rico for a local newspaper during the 1960s and struggles to find a balance between island culture and the expatriates who live there.",
                        120,
                        "The Rum Diary",
                        2011
                    },
                    {
                        106,
                        "Ken Watanabe, Tom Cruise, William Atherton, Chad Lindberg",
                        "Edward Zwick",
                        "Action,Drama,History",
                        "http=//ia.media-imdb.com/images/M/MV5BMzkyNzQ1Mzc0NV5BMl5BanBnXkFtZTcwODg3MzUzMw@@._V1_SX300.jpg",
                        "An American military advisor embraces the Samurai culture he was hired to destroy after he is captured in battle.",
                        154,
                        "The Last Samurai",
                        2003
                    },
                    {
                        107,
                        "Jack Nicholson, Faye Dunaway, John Huston, Perry Lopez",
                        "Roman Polanski",
                        "Drama,Mystery,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BN2YyNDE5NzItMjAwNC00MGQxLTllNjktZGIzMWFkZjA3OWQ0XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg",
                        "A private detective hired to expose an adulterer finds himself caught up in a web of deceit, corruption and murder.",
                        130,
                        "Chinatown",
                        1974
                    },
                    {
                        108,
                        "Brendan Gleeson, Chris O'Dowd, Kelly Reilly, Aidan Gillen",
                        "John Michael McDonagh",
                        "Comedy,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTc3MjQ1MjE2M15BMl5BanBnXkFtZTgwNTMzNjE4MTE@._V1_SX300.jpg",
                        "After he is threatened during a confession, a good-natured priest must battle the dark forces closing in around him.",
                        102,
                        "Calvary",
                        2014
                    },
                    {
                        109,
                        "Ethan Hawke, Julie Delpy, Vernon Dobtcheff, Louise Lemoine Torrès",
                        "Richard Linklater",
                        "Drama,Romance",
                        "http=//ia.media-imdb.com/images/M/MV5BMTQ1MjAwNTM5Ml5BMl5BanBnXkFtZTYwNDM0MTc3._V1_SX300.jpg",
                        "Nine years after Jesse and Celine first met, they encounter each other again on the French leg of Jesse's book tour.",
                        80,
                        "Before Sunset",
                        2004
                    },
                    {
                        110,
                        "Rumi Hiiragi, Miyu Irino, Mari Natsuki, Takashi Naitô",
                        "Hayao Miyazaki",
                        "Animation,Adventure,Family",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjYxMDcyMzIzNl5BMl5BanBnXkFtZTYwNDg2MDU3._V1_SX300.jpg",
                        "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts.",
                        125,
                        "Spirited Away",
                        2001
                    },
                    {
                        111,
                        "Catherine Deneuve, Vincent Perez, Linh Dan Pham, Jean Yanne",
                        "Régis Wargnier",
                        "Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTM1MTkzNzA3NF5BMl5BanBnXkFtZTYwNTI2MzU5._V1_SX300.jpg",
                        "This story is set in 1930, at the time when French colonial rule in Indochina is ending. A widowed French woman who works in the rubber fields, raises a Vietnamese princess as if she was ...",
                        159,
                        "Indochine",
                        1992
                    },
                    {
                        112,
                        "Michael Keaton, Emma Stone, Kenny Chin, Jamahl Garrison-Lowe",
                        "Alejandro G. Iñárritu",
                        "Comedy,Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BODAzNDMxMzAxOV5BMl5BanBnXkFtZTgwMDMxMjA4MjE@._V1_SX300.jpg",
                        "Illustrated upon the progress of his latest Broadway play, a former popular actor's struggle to cope with his current life as a wasted actor is shown.",
                        119,
                        "Birdman or (The Unexpected Virtue of Ignorance)",
                        2014
                    },
                    {
                        113,
                        "Ellar Coltrane, Patricia Arquette, Elijah Smith, Lorelei Linklater",
                        "Richard Linklater",
                        "Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTYzNDc2MDc0N15BMl5BanBnXkFtZTgwOTcwMDQ5MTE@._V1_SX300.jpg",
                        "The life of Mason, from early childhood to his arrival at college.",
                        165,
                        "Boyhood",
                        2014
                    },
                    {
                        114,
                        "Martin Balsam, John Fiedler, Lee J. Cobb, E.G. Marshall",
                        "Sidney Lumet",
                        "Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BODQwOTc5MDM2N15BMl5BanBnXkFtZTcwODQxNTEzNA@@._V1_SX300.jpg",
                        "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                        96,
                        "12 Angry Men",
                        1957
                    },
                    {
                        115,
                        "Benedict Cumberbatch, Keira Knightley, Matthew Goode, Rory Kinnear",
                        "Morten Tyldum",
                        "Biography,Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNDkwNTEyMzkzNl5BMl5BanBnXkFtZTgwNTAwNzk3MjE@._V1_SX300.jpg",
                        "During World War II, mathematician Alan Turing tries to crack the enigma code with help from fellow mathematicians.",
                        114,
                        "The Imitation Game",
                        2014
                    },
                    {
                        116,
                        "Ellen Burstyn, Matthew McConaughey, Mackenzie Foy, John Lithgow",
                        "Christopher Nolan",
                        "Adventure,Drama,Sci-Fi",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjIxNTU4MzY4MF5BMl5BanBnXkFtZTgwMzM4ODI3MjE@._V1_SX300.jpg",
                        "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                        169,
                        "Interstellar",
                        2014
                    },
                    {
                        117,
                        "David Schwimmer, Simon Pegg, Alice Eve, Natascha McElhone",
                        "Jean-Baptiste Andrea",
                        "Comedy,Crime,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY5NTc2NjYwOV5BMl5BanBnXkFtZTcwMzk5OTY0MQ@@._V1_SX300.jpg",
                        "A frustrated, unemployed teacher joining forces with a scammer and his girlfriend in a blackmailing scheme.",
                        86,
                        "Big Nothing",
                        2006
                    },
                    {
                        118,
                        "Jürgen Prochnow, Herbert Grönemeyer, Klaus Wennemann, Hubertus Bengsch",
                        "Wolfgang Petersen",
                        "Adventure,Drama,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjE5Mzk5OTQ0Nl5BMl5BanBnXkFtZTYwNzUwMTQ5._V1_SX300.jpg",
                        "The claustrophobic world of a WWII German U-boat; boredom, filth, and sheer terror.",
                        149,
                        "Das Boot",
                        1981
                    },
                    {
                        119,
                        "Mike Myers, Eddie Murphy, Cameron Diaz, Julie Andrews",
                        "Andrew Adamson, Kelly Asbury, Conrad Vernon",
                        "Animation,Adventure,Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTk4MTMwNjI4M15BMl5BanBnXkFtZTcwMjExMzUyMQ@@._V1_SX300.jpg",
                        "Princess Fiona's parents invite her and Shrek to dinner to celebrate her marriage. If only they knew the newlyweds were both ogres.",
                        93,
                        "Shrek 2",
                        2004
                    },
                    {
                        120,
                        "Jessica Alba, Devon Aoki, Alexis Bledel, Powers Boothe",
                        "Frank Miller, Robert Rodriguez, Quentin Tarantino",
                        "Crime,Thriller",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BODZmYjMwNzEtNzVhNC00ZTRmLTk2M2UtNzE1MTQ2ZDAxNjc2XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                        "A film that explores the dark and miserable town, Basin City, and tells the story of three different people, all caught up in violent corruption.",
                        124,
                        "Sin City",
                        2005
                    },
                    {
                        121,
                        "Bruce Dern, Will Forte, June Squibb, Bob Odenkirk",
                        "Alexander Payne",
                        "Adventure,Comedy,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU2Mjk2NDkyMl5BMl5BanBnXkFtZTgwNTk0NzcyMDE@._V1_SX300.jpg",
                        "An aging, booze-addled father makes the trip from Montana to Nebraska with his estranged son in order to claim a million-dollar Mega Sweepstakes Marketing prize.",
                        115,
                        "Nebraska",
                        2013
                    },
                    {
                        122,
                        "Mike Myers, Eddie Murphy, Cameron Diaz, John Lithgow",
                        "Andrew Adamson, Vicky Jenson",
                        "Animation,Adventure,Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTk2NTE1NTE0M15BMl5BanBnXkFtZTgwNjY4NTYxMTE@._V1_SX300.jpg",
                        "After his swamp is filled with magical creatures, an ogre agrees to rescue a princess for a villainous lord in order to get his land back.",
                        90,
                        "Shrek",
                        2001
                    },
                    {
                        123,
                        "Brad Pitt, Angelina Jolie, Vince Vaughn, Adam Brody",
                        "Doug Liman",
                        "Action,Comedy,Crime",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTUxMzcxNzQzOF5BMl5BanBnXkFtZTcwMzQxNjUyMw@@._V1_SX300.jpg",
                        "A bored married couple is surprised to learn that they are both assassins hired by competing agencies to kill each other.",
                        120,
                        "Mr. & Mrs. Smith",
                        2005
                    },
                    {
                        124,
                        "Antonio Banderas, Angelina Jolie, Thomas Jane, Jack Thompson",
                        "Michael Cristofer",
                        "Drama,Mystery,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BODg3Mjg0MDY4M15BMl5BanBnXkFtZTcwNjY5MDQ2NA@@._V1_SX300.jpg",
                        "A woman along with her lover, plan to con a rich man by marrying him and on earning his trust running away with all his money. Everything goes as planned until she actually begins to fall in love with him.",
                        116,
                        "Original Sin",
                        2001
                    },
                    {
                        125,
                        "Mike Myers, Eddie Murphy, Cameron Diaz, Antonio Banderas",
                        "Mike Mitchell",
                        "Animation,Adventure,Comedy",
                        "http=//ia.media-imdb.com/images/M/MV5BMTY0OTU1NzkxMl5BMl5BanBnXkFtZTcwMzI2NDUzMw@@._V1_SX300.jpg",
                        "Rumpelstiltskin tricks a mid-life crisis burdened Shrek into allowing himself to be erased from existence and cast in a dark alternate timeline where Rumpel rules supreme.",
                        93,
                        "Shrek Forever After",
                        2010
                    },
                    {
                        126,
                        "Ethan Hawke, Julie Delpy, Seamus Davey-Fitzpatrick, Jennifer Prior",
                        "Richard Linklater",
                        "Drama,Romance",
                        "http=//ia.media-imdb.com/images/M/MV5BMjA5NzgxODE2NF5BMl5BanBnXkFtZTcwNTI1NTI0OQ@@._V1_SX300.jpg",
                        "We meet Jesse and Celine nine years on in Greece. Almost two decades have passed since their first meeting on that train bound for Vienna.",
                        109,
                        "Before Midnight",
                        2013
                    },
                    {
                        127,
                        "Steve Carell, Jason Segel, Russell Brand, Julie Andrews",
                        "Pierre Coffin, Chris Renaud",
                        "Animation,Adventure,Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY3NjY0MTQ0Nl5BMl5BanBnXkFtZTcwMzQ2MTc0Mw@@._V1_SX300.jpg",
                        "When a criminal mastermind uses a trio of orphan girls as pawns for a grand scheme, he finds their love is profoundly changing him for the better.",
                        95,
                        "Despicable Me",
                        2010
                    },
                    {
                        128,
                        "Julian Glover, Brian Cox, Nathan Jones, Adoni Maropis",
                        "Wolfgang Petersen",
                        "Adventure",
                        "http=//ia.media-imdb.com/images/M/MV5BMTk5MzU1MDMwMF5BMl5BanBnXkFtZTcwNjczODMzMw@@._V1_SX300.jpg",
                        "An adaptation of Homer's great epic, the film follows the assault on Troy by the united Greek forces and chronicles the fates of the men involved.",
                        163,
                        "Troy",
                        2004
                    },
                    {
                        129,
                        "Ian McKellen, Martin Freeman, Richard Armitage, Ken Stott",
                        "Peter Jackson",
                        "Adventure,Fantasy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTcwNTE4MTUxMl5BMl5BanBnXkFtZTcwMDIyODM4OA@@._V1_SX300.jpg",
                        "A reluctant hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home - and the gold within it - from the dragon Smaug.",
                        169,
                        "The Hobbit= An Unexpected Journey",
                        2012
                    },
                    {
                        130,
                        "Lisa Adam, Frank Aldridge, Amitabh Bachchan, Steve Bisley",
                        "Baz Luhrmann",
                        "Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTkxNTk1ODcxNl5BMl5BanBnXkFtZTcwMDI1OTMzOQ@@._V1_SX300.jpg",
                        "A writer and wall street trader, Nick, finds himself drawn to the past and lifestyle of his millionaire neighbor, Jay Gatsby.",
                        143,
                        "The Great Gatsby",
                        2013
                    },
                    {
                        131,
                        "Ray Romano, John Leguizamo, Denis Leary, Goran Visnjic",
                        "Chris Wedge, Carlos Saldanha",
                        "Animation,Adventure,Comedy",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjEyNzI1ODA0MF5BMl5BanBnXkFtZTYwODIxODY3._V1_SX300.jpg",
                        "Set during the Ice Age, a sabertooth tiger, a sloth, and a wooly mammoth find a lost human infant, and they try to return him to his tribe.",
                        81,
                        "Ice Age",
                        2002
                    },
                    {
                        132,
                        "Alan Howard, Noel Appleby, Sean Astin, Sala Baker",
                        "Peter Jackson",
                        "Action,Adventure,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNTEyMjAwMDU1OV5BMl5BanBnXkFtZTcwNDQyNTkxMw@@._V1_SX300.jpg",
                        "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle Earth from the Dark Lord Sauron.",
                        178,
                        "The Lord of the Rings= The Fellowship of the Ring",
                        2001
                    },
                    {
                        133,
                        "Bruce Allpress, Sean Astin, John Bach, Sala Baker",
                        "Peter Jackson",
                        "Action,Adventure,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTAyNDU0NjY4NTheQTJeQWpwZ15BbWU2MDk4MTY2Nw@@._V1_SX300.jpg",
                        "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                        179,
                        "The Lord of the Rings= The Two Towers",
                        2002
                    },
                    {
                        134,
                        "Domhnall Gleeson, Corey Johnson, Oscar Isaac, Alicia Vikander",
                        "Alex Garland",
                        "Drama,Mystery,Sci-Fi",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_SX300.jpg",
                        "A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a breath-taking humanoid A.I.",
                        108,
                        "Ex Machina",
                        2015
                    },
                    {
                        135,
                        "Eddie Redmayne, Felicity Jones, Tom Prior, Sophie Perry",
                        "James Marsh",
                        "Biography,Drama,Romance",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTAwMTU4MDA3NDNeQTJeQWpwZ15BbWU4MDk4NTMxNTIx._V1_SX300.jpg",
                        "A look at the relationship between the famous physicist Stephen Hawking and his wife.",
                        123,
                        "The Theory of Everything",
                        2014
                    },
                    {
                        136,
                        "Richard Chamberlain, Toshirô Mifune, Yôko Shimada, Furankî Sakai",
                        "N/A",
                        "Adventure,Drama,History",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTY1ODI4NzYxMl5BMl5BanBnXkFtZTcwNDA4MzUxMQ@@._V1_SX300.jpg",
                        "A English navigator becomes both a player and pawn in the complex political games in feudal Japan.",
                        60,
                        "Shogun",
                        1980
                    },
                    {
                        137,
                        "Mark Ruffalo, Michael Keaton, Rachel McAdams, Liev Schreiber",
                        "Tom McCarthy",
                        "Biography,Crime,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjIyOTM5OTIzNV5BMl5BanBnXkFtZTgwMDkzODE2NjE@._V1_SX300.jpg",
                        "The true story of how the Boston Globe uncovered the massive scandal of child molestation and cover-up within the local Catholic Archdiocese, shaking the entire Catholic Church to its core.",
                        128,
                        "Spotlight",
                        2015
                    },
                    {
                        138,
                        "James Stewart, Kim Novak, Barbara Bel Geddes, Tom Helmore",
                        "Alfred Hitchcock",
                        "Mystery,Romance,Thriller",
                        "http=//ia.media-imdb.com/images/M/MV5BNzY0NzQyNzQzOF5BMl5BanBnXkFtZTcwMTgwNTk4OQ@@._V1_SX300.jpg",
                        "A San Francisco detective suffering from acrophobia investigates the strange activities of an old friend's wife, all the while becoming dangerously obsessed with her.",
                        128,
                        "Vertigo",
                        1958
                    },
                    {
                        139,
                        "Miles Teller, J.K. Simmons, Paul Reiser, Melissa Benoist",
                        "Damien Chazelle",
                        "Drama,Music",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTU4OTQ3MDUyMV5BMl5BanBnXkFtZTgwOTA2MjU0MjE@._V1_SX300.jpg",
                        "A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student's potential.",
                        107,
                        "Whiplash",
                        2014
                    },
                    {
                        140,
                        "Martina Gedeck, Ulrich Mühe, Sebastian Koch, Ulrich Tukur",
                        "Florian Henckel von Donnersmarck",
                        "Drama,Thriller",
                        "http=//ia.media-imdb.com/images/M/MV5BNDUzNjYwNDYyNl5BMl5BanBnXkFtZTcwNjU3ODQ0MQ@@._V1_SX300.jpg",
                        "In 1984 East Berlin, an agent of the secret police, conducting surveillance on a writer and his lover, finds himself becoming increasingly absorbed by their lives.",
                        137,
                        "The Lives of Others",
                        2006
                    },
                    {
                        141,
                        "Xolani Mali, Don Cheadle, Desmond Dube, Hakeem Kae-Kazim",
                        "Terry George",
                        "Drama,History,War",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTI2MzQyNTc1M15BMl5BanBnXkFtZTYwMjExNjc3._V1_SX300.jpg",
                        "Paul Rusesabagina was a hotel manager who housed over a thousand Tutsi refugees during their struggle against the Hutu militia in Rwanda.",
                        121,
                        "Hotel Rwanda",
                        2004
                    },
                    {
                        142,
                        "Matt Damon, Jessica Chastain, Kristen Wiig, Jeff Daniels",
                        "Ridley Scott",
                        "Adventure,Drama,Sci-Fi",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMTc2MTQ3MDA1Nl5BMl5BanBnXkFtZTgwODA3OTI4NjE@._V1_SX300.jpg",
                        "An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive.",
                        144,
                        "The Martian",
                        2015
                    },
                    {
                        143,
                        "Gregory Peck, John Megna, Frank Overton, Rosemary Murphy",
                        "Robert Mulligan",
                        "Crime,Drama",
                        "http=//ia.media-imdb.com/images/M/MV5BMjA4MzI1NDY2Nl5BMl5BanBnXkFtZTcwMTcyODc5Mw@@._V1_SX300.jpg",
                        "Atticus Finch, a lawyer in the Depression-era South, defends a black man against an undeserved rape charge, and his kids against prejudice.",
                        129,
                        "To Kill a Mockingbird",
                        1962
                    },
                    {
                        144,
                        "Samuel L. Jackson, Kurt Russell, Jennifer Jason Leigh, Walton Goggins",
                        "Quentin Tarantino",
                        "Crime,Drama,Mystery",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BMjA1MTc1NTg5NV5BMl5BanBnXkFtZTgwOTM2MDEzNzE@._V1_SX300.jpg",
                        "In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters.",
                        187,
                        "The Hateful Eight",
                        2015
                    },
                    {
                        145,
                        "Peyman Moaadi, Leila Hatami, Sareh Bayat, Shahab Hosseini",
                        "Asghar Farhadi",
                        "Drama,Mystery",
                        "http=//ia.media-imdb.com/images/M/MV5BMTYzMzU4NDUwOF5BMl5BanBnXkFtZTcwMTM5MjA5Ng@@._V1_SX300.jpg",
                        "A married couple are faced with a difficult decision - to improve the life of their child by moving to another country or to stay in Iran and look after a deteriorating parent who has Alzheimer's disease.",
                        123,
                        "A Separation",
                        2011
                    },
                    {
                        146,
                        "Ryan Gosling, Rudy Eisenzopf, Casey Groves, Charlie Talbert",
                        "Adam McKay",
                        "Biography,Comedy,Drama",
                        "https=//images-na.ssl-images-amazon.com/images/M/MV5BNDc4MThhN2EtZjMzNC00ZDJmLThiZTgtNThlY2UxZWMzNjdkXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg",
                        "Four denizens in the world of high-finance predict the credit and housing bubble collapse of the mid-2000s, and decide to take on the big banks for their greed and lack of foresight.",
                        130,
                        "The Big Short",
                        2015
                    }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 1);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 2);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 3);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 4);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 5);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 6);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 7);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 8);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 9);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 10);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 11);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 12);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 13);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 14);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 15);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 16);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 17);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 18);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 19);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 20);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 21);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 22);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 23);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 24);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 25);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 26);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 27);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 28);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 29);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 30);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 31);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 32);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 33);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 34);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 35);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 36);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 37);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 38);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 39);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 40);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 41);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 42);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 43);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 44);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 45);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 46);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 47);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 48);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 49);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 50);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 51);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 52);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 53);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 54);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 55);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 56);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 57);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 58);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 59);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 60);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 61);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 62);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 63);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 64);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 65);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 66);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 67);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 68);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 69);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 70);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 71);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 72);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 73);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 74);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 75);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 76);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 77);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 78);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 79);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 80);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 81);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 82);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 83);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 84);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 85);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 86);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 87);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 88);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 89);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 90);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 91);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 92);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 93);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 94);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 95);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 96);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 97);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 98);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 99);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 100);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 101);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 102);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 103);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 104);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 105);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 106);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 107);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 108);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 109);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 110);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 111);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 112);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 113);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 114);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 115);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 116);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 117);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 118);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 119);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 120);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 121);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 122);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 123);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 124);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 125);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 126);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 127);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 128);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 129);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 130);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 131);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 132);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 133);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 134);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 135);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 136);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 137);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 138);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 139);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 140);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 141);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 142);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 143);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 144);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 145);

            migrationBuilder.DeleteData(table: "Movies", keyColumn: "Id", keyValue: 146);
        }
    }
}
