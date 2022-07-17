var countries = new Array();
countries['North America']  = new Array('Select a country', 'United States', 'Canada', 'Mexico');
countries['Europe']         = new Array('Select a country', 'Spain');
countries['Asia']           = new Array('Select a country');
countries['South America']  = new Array('Select a country');
countries['Africa']         = new Array('Select a country');

var states = new Array();
states['North America'] = new Array();
states['North America']['Select a country'] = new Array('Select a state');
states['North America']['Canada'] = new Array('Select a territory' , 'Alberta', 'British Columbia', 'Ontario');
states['North America']['Mexico'] = new Array('Select a federal entity' , 'Baja California', 'Chihuahua', 'Jalisco');
states['North America']['United States'] = new Array('Select a state', 'Alabama', 'Alaska', 'Arizona', 'Arkansas', 'California', 'Colorado', 'Connecticut', 'Delaware', 'District of Columbia', 'Florida', 'Georgia', 'Hawaii', 'Idaho', 'Illinios', 'Indiana', 'Iowa', 'Kansas', 'Kentucky', 'Louisiana', 'Maine', 'Maryland', 'Massachusetts', 'Michigan', 'Minnesota', 'Mississippi', 'Missouri', 'Montana', 'Nebraska', 'Nevada', 'New Hampshire', 'New Jersey', 'New Mexico', 'New York', 'North Carolina', 'North Dakota', 'Ohio', 'Oklahoma', 'Oregon', 'Pennsylvania', 'Rhode Island', 'South Carolina', 'South Dakota', 'Tennessee', 'Texas', 'Utah', 'Vermont', 'Virginia', 'Washington', 'West Virginia', 'Wisconsin', 'Wyoming');
states['Europe'] = new Array();
states['Europe']['Select a country'] = new Array('Select a state');
states['Europe']['Spain'] = new Array('Galacia', 'Barcelona' );


// City lists
var cities = new Array();
cities['North America'] = new Array();
cities['North America']['Select a country'] = new Array();
cities['North America']['Select a country']['Select a state'] = new Array('Select a city');
cities['North America']['Canada'] = new Array();
cities['North America']['Canada']['Select a territory']         = new Array('Select a city');
cities['North America']['Canada']['Alberta']                    = new Array('Select a city', 'Edmonton', 'Calgary');
cities['North America']['Canada']['British Columbia']           = new Array('Select a city', 'Victoria', 'Vancouver');
cities['North America']['Canada']['Ontario']                    = new Array('Select a city', 'Toronto', 'Hamilton');

cities['North America']['Mexico'] = new Array();
cities['North America']['Mexico']['Select a federal entity']    = new Array('Select a city');
cities['North America']['Mexico']['Baja California']            = new Array('Select a city', 'Tijauna', 'Mexicali');
cities['North America']['Mexico']['Chihuahua']                  = new Array('Select a city', 'Ciudad Ju�rez', 'Chihuahua');
cities['North America']['Mexico']['Jalisco']                    = new Array('Select a city', 'Guadalajara', 'Chapala');

cities['Europe'] = new Array();
cities['Europe']['Select a country'] = new Array();
cities['Europe']['Select a country']['Select a state'] = new Array('Select a city');
cities['Europe']['Spain'] = new Array();
cities['Europe']['Spain']['Select a district'] = new Array('Select a city');
cities['Europe']['Spain']['Galacia'] = new Array('Select a city', 'A Corona', 'Ferrol');
cities['Europe']['Spain']['Barcelona'] = new Array('Select a city', 'Barcalona');

cities['North America']['United States'] = new Array();
cities['North America']['United States']['Select a state'] = new Array('Select a city');
cities['North America']['United States']['Alabama'] = new Array('Select a city', 'Abbeville', 'Alabaster', 'Albertville', 'Alexander City', 'Aliceville', 'Andalusia', 'Arab', 'Ashland', 'Ashville', 'Athens', 'Atmore', 'Attalla', 'Auburn', 'Bay Minette', 'Birmingham', 'Boaz', 'Brent', 'Brewton', 'Bridgeport', 'Calera', 'Camden', 'Carrollton', 'Centre', 'Centreville', 'Childersburg', 'Citronelle', 'Clanton', 'Columbiana', 'Cullman', 'Dadeville', 'Dadeville', 'Daphne', 'Decatur', 'Demopolis', 'Dothan', 'East Brewton', 'Elba', 'Enterprise', 'Eufaula', 'Eutaw', 'Evergreen', 'Fairhope', 'Fayette', 'Florence', 'Foley', 'Fort Payne', 'Fultondale', 'Gadsden', 'Geneva', 'Greensboro', 'Greenville', 'Guin', 'Gulf Shores', 'Guntersville', 'Haleyville', 'Hamilton', 'Hanceville', 'Hartford', 'Hartselle', 'Headland', 'Heflin', 'Henagar', 'Homewood', 'Hoover', 'Huntsville', 'Irondale', 'Jackson', 'Jacksonville', 'Jasper', 'Lanette', 'Lincoln', 'Linden', 'Lineville', 'Livingston', 'Luverne', 'Madison', 'Marion', 'Monroeville', 'Montevallo', 'Montgomery', 'Moulton', 'Muscle Shoals', 'Northport', 'Oneonta', 'Opelika', 'Opp', 'Orange Beach', 'Oxford', 'Ozark', 'Pelham', 'Pell City', 'Phenix City', 'Piedmont', 'Pinson', 'Prattville', 'Prichard', 'Rainbow City', 'Rainsville', 'Red Bay', 'Roanoke', 'Robertsdale', 'Russellville', 'Saraland', 'Scottsboro', 'Selma', 'Sheffield', 'Spanish Fort', 'Springville', 'Sumiton', 'Sylacauga', 'Talladega', 'Tallassee', 'Theodore', 'Thomasville', 'Troy', 'Trussville', 'Tuscaloosa', 'Tuscumbia', 'Tuskegee', 'Union Springs', 'Valley', 'Vernon', 'Warrior', 'Wedowee', 'Wetumpka', 'Winfield', 'York');
cities['North America']['United States']['Alaska'] = new Array('Select a city', 'Alakanuk', 'Allakaket', 'Anchorage', 'Aniak', 'Bethal', 'Chignik', 'Cold Bay', 'Delata Junction', 'Dillingham', 'Eagle', 'Eak', 'Fairbanks', 'Fort Yukon', 'Haines', 'Homer', 'Hoonah', 'Hooper Bay', 'Juneau', 'Kaltag', 'Kenai', 'Ketchikan', 'Kodiak', 'Kotlik', 'Kotzebue', 'Kwethluk', 'Kwigillingok', 'McGrath', 'Nenana', 'Ninilchik', 'Nome', 'Palmer', 'Perryville', 'Petersburg', 'Point Hope', 'Ruby', 'Sand Point', 'Savoonga', 'Scammon Bay', 'Seward', 'Seward', 'Shungnak', 'Sitka', 'Skagway', 'Soldotna', 'Tanana', 'Umiate', 'Unalaska', 'Utqiagvik', 'Valdez', 'Wainwrite', 'Wasilla', 'Willow', 'Wrangell', 'Yakutat');
cities['North America']['United States']['Arizona'] = new Array('Select a city', 'Anthem', 'Apache Junction', 'Avondale', 'Benson', 'Bisbee', 'Buckeye', 'Bullhead City', 'Casa Grande', 'Chandler', 'Chinle', 'Coolidge', 'Cottonwood', 'Dolan Springs', 'Douglas', 'Eloy', 'Flagstaff', 'Florence', 'Fort Defiance', 'Ganado', 'Gila Bend', 'Glendale', 'Glendale', 'Globe', 'Green Valley', 'HolBrook', 'Kaibito', 'Kingman', 'Lake Havasu City', 'Lukachukai', 'Mammoth', 'Many farms', 'Mayer', 'Mesa', 'Morenci', 'Nogales', 'Oracle', 'Oro Valley', 'Page', 'Parker', 'Paulden', 'Peoria', 'Phoenix', 'Pine', 'Prescott', 'Sacaton', 'Safford', 'St Johns', 'Salome', 'San Carlos', 'San luis', 'San Manuel', 'Scottsdale', 'Sedona', 'Sells', 'Show Low', 'Sierra Vista', 'Somerton', 'Sun City', 'Tempe', 'Tombstone', 'Tuba City', 'Tucson', 'Tucson Estates', 'Vail', 'Whiteriver', 'Willcox', 'Williams', 'Winslow', 'Yuma');
cities['North America']['United States']['Arkansas'] = new Array('Select a city', 'Ash Flat', 'Agusta', 'Batesville', 'Bella Vista', 'Benton', ' Bentonville', 'Beryville', 'Blythville', 'Booneville', 'Cabot', 'Camden', 'Charleston', 'Clarendon', ' Clarksville', 'Clinton', 'Conway', 'Corning', 'Crossett', 'Danville', 'Dardanelle', 'De Queen', 'De Valls Bluff', 'De Witt', 'Des Arc', 'Dumas', 'El Dorado', 'Eureka Springs', 'Fayetteville', 'Fordyce', 'Forrest City', 'Fort Smith', 'Greenwood', 'Hamburg', 'Hampton', 'Harrisburg', 'Harrison', 'Heber Springs', 'Helena-W Helena', 'Hope', 'Hot Springs', 'Hot Springs Village', 'Huntsville', 'Jacksonville', 'Jasper', 'Jonesboro', 'Lake City', 'Lake Village', 'Lewisville', 'Little Rock', 'Lonoke', 'Magnolia', 'Malvern', 'Marion', 'Marshall', 'McGehee', 'Melbourne', 'Mena', 'Monticello', 'Morrilton', 'Mount Ida', 'Mountain Home', 'Mountain View', 'Murfreesboro', 'Nashville', 'Newport', 'North Little Rock', 'Osceola', 'Ozark', 'Paragould', 'Paris', 'Perryville', 'Piggot', 'Pine Bluff', 'Pocahontas', 'Prescott', 'Rison', 'Rogers', 'Russellville', 'Salem', 'Searcy', 'Sheridan', 'Siloam Springs', 'Springdale', 'Star City', 'Stuttgart', 'Texarkana', 'Trumman', 'Van Buren', 'Waldron', 'Warren', 'West Memphis', 'Wynne', 'Yellville');
cities['North America']['United States']['California'] = new Array('Select a city', 'Adelanto', 'Alpine', 'Anaheim', 'Anderson', 'Angels Camp', 'Antioch', 'Arcata', 'Arroyo Grande', 'Arvin', 'Atascadero', 'Atwater', 'Auburn', 'Avalon', 'Avenal', 'Bakersfield', 'Barstow', 'Bayview', 'Beaumont', 'Berkeley', 'Bishop', 'Blythe', 'Brawley', 'Brentwood', 'Carlsbad', 'Carmel-by-the-sea', 'Carpenteria', 'Chico', 'Chowchilla', 'Chula Vista', 'Clearlake Oaks', 'Cloverdale', 'Clovis', 'Coalinga', 'Compton', 'Colusa', 'Corcoran', 'Corning', 'Corona', 'Cotati', 'Cottonwood', 'Cresent City', 'Delano', 'Desert Hot Springs', 'Dinuba', 'Dixon', 'Earlimart', 'EL Cajon', 'El Centro', 'Encinitas', 'Escondido', 'Eureka', 'Exeter', 'Fairfield', 'Firebaugh', 'Folsom', 'Fort Bragg', 'Fortuna', 'Fowler', 'Fremont', 'Fresno', 'Gilroy', 'Glendale', 'Grass Valley', 'Greenfield', 'Grover Beach', 'Guadalupe', 'Gustine', 'Hanford', 'Healdsburg', 'Hemet', 'Hesperia', 'Hollister', 'Holtville', 'Huron', 'Imperial', 'Indio', 'Ione', 'Irvine', 'Jackson', 'JKerman', 'King City', 'Kingsburg', 'Lake Elsinore', 'Lakeport', 'Lancaster', 'Lathrop', 'Lemoore', 'Lincoln', 'Lindsay', 'Livermore', 'Livingston', 'Lodi', 'Loma Linda', 'Lompoc', 'Long Beach', 'Los Angeles', 'Los Banos', 'Medera', 'Manteca', 'Martinez', 'Marysville', 'McFarland', 'Mendota', 'Merced', 'Milipitas', 'Modesto', 'Montecito', 'Monterey', 'Moorpark', 'Morgan Hill', 'Napa', 'National City', 'Needles', 'Nevada City', 'Newman', 'Newport Beach', 'Novato', 'Oakland', 'Oakley', 'Oceanside', 'Ontairo', 'Orland', 'Oroville', 'Oxnard', 'Pacific Grove', 'Palm Desert', 'Palm Springs', 'Palmdale', 'Palo Alto', 'Pasadena', 'Paso Robles', 'Patterson', 'Perris', 'Pittsburg', 'Placerville', 'Porterville', 'Quincy', 'Ramona', 'Rancho Cordova', 'Red Bluff', 'Redding', 'Redlands', 'Redwood City', 'Ridgecrest', 'Rio Dell', 'Riverside', 'Rocklin', 'Roseville', 'Sacramento', 'Salinas', 'San Bernadino', 'San Clemente', 'San Diego', 'San Fransico', 'San Jacinto', 'San Jose', 'San juan Capistrano', 'San Luis Obispo', 'San Marcos', 'Santa Anna', 'Santa Barbra', 'Santa Clarita', 'Santa Cruz', 'Santa Maria', 'Santa Paula', 'Santa Rosa', 'Saratoga', 'Seaside', 'Sebastopol', 'Selma', 'Shafter', 'Simi Valley', 'Soledad', 'Solvang', 'South Lake Tahoe', 'South San Frinsico', 'Stockton', 'Taft', 'Tehachapi', 'Temecula', 'Thousand oaks', 'Tracy', 'Tular', 'Turlock', 'Twentynine Palms', 'Ukiah', 'Vacaville', 'Vallejo', 'Victorville', 'Vista', 'Wasco', 'Watsonville', 'Williams', 'Willits', 'Willows', 'Winters', 'Woodlake', 'Woodland', 'Yreka', 'Yuba City', 'Yacca Valley');
cities['North America']['United States']['Connecticut'] = new Array('Select a city', 'Ansonia', 'Bridgeport', 'Bristol', 'Brooklyn', 'Danbury', 'Derby', 'Farmington', 'Hartford', 'Meriden', 'Middletown', 'Milford', 'New Britain', 'New Haven', 'New London', 'Norwalk', 'Norwich', 'Shelton', 'Stamford', 'Torrington', 'Waterbury', 'West Haven');
cities['North America']['United States']['Colorado'] = new Array('Select a city', 'Alamosa', 'Arvada', 'Aspen', 'Arora', 'Boulder', 'Breckenridge', 'Brighton', 'Brush', 'Burlington', 'Canon City', 'Central City', 'Cortez', 'Craig', 'Denver', 'Durango', 'Glenwood Springs', 'Golden', 'Grand Junction', 'Greeley', 'Gunnison', 'Steamboat Springs', 'Telluride', 'Thornton', 'Trinidad', 'Walsenburg', 'Wellington', 'Westcliffe', 'Woodland Park', 'Wray', 'Yuma');
cities['North America']['United States']['Delaware'] = new Array('Select a city', 'Dover', 'Harrington', 'Lewes', 'Milford', 'Millsboro', 'Milton', 'New Castle', 'Newark', 'Rehoboth Beach', 'Seaford', 'Wilmington');
cities['North America']['United States']['District of Columbia'] = new Array('Select a city', 'Washington');
cities['North America']['United States']['Florida'] = new Array('Select a city', 'Altmonte Springs', 'Arcadia', 'Atlantic Beach', 'Bartow', 'Belle Glade', 'Blountstown', 'Boca Raton', 'Bonifay', 'Bradenton', 'Brandon', 'Brooksville', 'Bunnell', 'Bushnell', 'Cape Canaveral', 'Cape Coral', 'Chipley', 'Clearwater', 'Cape Coral', 'Chipley', 'Clearwater', 'Clermont', 'Coca Beach', 'Coral Gables', 'Dania Beach', 'Daytona Beach', 'De Funiak Springs', 'DeBary', 'Deerfield Beach', 'DeLand', 'Delray Beach', 'Dunedin', 'Edgewater', 'Eustis', 'Fernandina Beach', 'Fort Lauderdale', 'Fort Myers', 'Fort Pierce', 'Fort Walton Beach', 'Gainseville', 'Green Cove Springs', 'Haines City', 'Hallandale', 'Hialeah', 'Holly Hill', 'Hollywood', 'Homestead', 'Hudson', 'Inverness', 'Jacksonville', 'Jacksonville Beach', 'Jasper', 'Key West', 'Kissimmee', 'La Belle', 'Lake Buena Vista', 'Lake Butler', 'Lake City', 'Lake Wales', 'Lake Worth Beach', 'Lakeland', 'Largo', 'Leesburg', 'Live Oak', 'Macclenny', 'Madeira Beach', 'Madison', 'Marathon', 'Marco Island', 'Marianna', 'Melbourne', 'Miami', 'Miami Beach', 'Milton', 'Monticello', 'Moore Haven', 'Naples', 'New Port Richey', 'New Smyrna Beach', 'Ocala', 'Okeechobee', 'Orlando', 'Ormond Beach', 'Palatka', 'Palm Bay', 'Palm Beach', 'Palm Coast', 'Palmetto', 'Panama City', 'Pensacola', 'Perry', 'Pompano Beach', 'Port Orange', 'Port st lucie', 'Punta Gorda', 'Quincy', 'St Augustine', 'St Cloud', 'St Pete Beach', 'St Petersburg', 'Sanford', 'Sarasota', 'Sebastian', 'Sebring', 'Starke', 'Stuart', 'Sunrise', 'Tallahassee', 'Tampa', 'Tarpon Springs', 'Tavares', 'Titusville', 'Trenton', 'Venice', 'Vero Beach', 'Warrington', 'Wauchula', 'West Palm Beach', 'Weston', 'Winter Garden', 'Winter Haven', 'Zephyrhills');
cities['North America']['United States']['Georgia'] = new Array('Select a city', 'Adel', 'Albany', 'Alpharetta', 'Americus', 'Athens', 'Atlanta', 'Tavares', 'Augusta', 'Austell', 'Bainbridge', 'Barnesville', 'Blakely', 'Bremen', 'Brunswick', 'Buford', 'Cairo', 'Calhoun', 'Camilla', 'Canton', 'Carrollton', 'Cartersville', 'Cedartown', 'Cochran', 'College Park', 'Columbus', 'Commerce', 'Conyers', 'Cordele', 'Covington', 'Cumming', 'Dallas', 'Dalton', 'Dawson', 'Decatur', 'Douglas', 'Douglasville', 'Dublin', 'Duluth', 'East Point', 'Eastman', 'Eatonton', 'Elberton', 'Fairburn', 'Fayetteville', 'Fitzgerald', 'Fort Oglethorp', 'Fort Valley', 'Gainesville', 'Glennville', 'Griffin', 'Hawkinsville', 'Hinesville', 'Jesup', 'Kingsland', 'La Grange', 'LaFayette', 'Lawrenceville', 'Lilburn', 'Macon', 'Marietta', 'McDonough', 'Milledgeville', 'Monroe', 'Morrow', 'Moultrie', 'Newnan', 'Norcross', 'Perry', 'Quitman', 'Rome', 'Roswell', 'St Marys', 'Sandersville', 'Savannah', 'Smyrna', 'Statesboro', 'Stockbridge', 'Stone Mountain', 'Summerville', 'Swainsboro', 'Thomaston', 'Thomasville', 'Thomson', 'Tifton', 'Toccoa', 'Valdosta', 'Vidalia', 'Warner Robins', 'Waycross', 'Waynesboro', 'Winder');
cities['North America']['United States']['Hawaii'] = new Array('Select a city', 'Aiea', 'Ewa Beach', 'Ewa Villages', 'Hana', 'Hau ula', 'Hilo', 'Holualoa', 'Honaunau', 'Honoka a', 'Honolulu', 'Kahalu u', 'Kahana', 'Kahuku', 'Kahului', 'Kailua', 'KailuaKona', 'Kainaliu', 'Kalaheo', 'Kalaupapa', 'Kane ohe', 'Kapa a', 'Kaunakakai', 'Kea au', 'Kekaha', 'Kihel', 'Kilauea', 'Kipahulu', 'Koloa', 'Kukuihaele', 'Kurtistown', 'Lahaina', 'La ie', 'Lanai City', 'Lihu e', 'Ma alaea', 'Maili', 'Makakilo City', 'Makaha', 'Makawao', 'Maunaloa', 'Na alehu', 'Nanakuli', 'O okala', 'Pahala', 'Pahoa', 'Papa ikou', ' Pa uwela', 'Pearl City', 'Pukalani', 'Volcano', 'Wahiawa', 'Waialua', 'Wa anae', 'Wailuku', 'Waimanalo', 'Waimanalo Beach', 'Waimea', 'Waipahu', 'Whitmore Village');
cities['North America']['United States']['Idaho'] = new Array('Select a city', 'Aberdeen', 'Albion', 'Arco', 'Ashton', 'Athol', 'Bancroft', 'Bellevue', 'Blackfoot', 'Bliss', 'Bloomington', 'Boise', 'Bonners Ferry', 'Bovill', 'Buhl', 'Burley', 'Caldwell', 'Cambridge', 'Carey', 'Cascade', 'Castleford', 'Challis', 'Clark Fork', 'Coeur d Alene', 'Cottonwood', 'Council', 'Craigmont', 'Culdesac', 'Dayton', 'Deary', 'Delco', 'Downey', 'Driggs', 'Dubois', 'Eden', 'Emmett', 'Fairfield', 'Filer', 'Firth', 'Franklin', 'Fruitland', 'Georgetown', 'Glenns Fairy', 'Gooding', 'Grace', 'Grand View', 'Grangeville', 'Hailey', 'Hammett', 'Hansen', 'Harrison', 'Hollister', 'Homedale', 'Horseshoe Bend', 'Idaho City', 'Idaho Falls', 'Inkom', 'Jerome', 'Kamiah', 'Kellogg', 'Kendrick', 'Ketchum', 'Kimberly', 'Kooskia', 'Kootenai', 'Letha', 'Lewiston', 'Malad City', 'Marsing', 'McCall', 'McCammon', 'Melba', 'Meridian', 'Montpelier', 'Moscow', 'Mountain Home', 'Moyie Springs', 'Mud Lake', 'Mullan', 'Nampa', 'New Meadows', 'New Plymouth', 'Newdale', 'Nezperce', 'Oaekly', 'Osburn', 'Paris', 'Paul', 'Payette', 'Pierce', 'Pinehurst', 'Plummer', 'Pocatello', 'Post Falls', 'Potlatch', 'Preston', 'Priest River', 'Rathdrum', 'Rexburg', 'Richfield', 'Rigby', 'Riggins', 'Ririe', 'Roberts', 'Rockland', 'Rupert', 'St Anthony', 'St Maries', 'Salmon', 'Sandpoint', 'Shelly', 'Shoshone', 'Soda Springs', 'Spirit Lake', 'Star', 'Sugar City', 'Sun Valley', 'Swan Valley', 'Tetonia', 'Troy', 'Twin Falls', 'Victor', 'Wallace', 'Weippe', 'Weiser', 'Wendell', 'Weston');
cities['North America']['United States']['Illinios'] = new Array('Select a city', 'Albion', 'Aledo', 'Alton', 'Aurora', 'Belleville', 'Belvidere', 'Benton', 'Bloomington', 'Cairo', 'Canton', 'Carbondale', 'Carlinville', 'Carlyle', 'Carmi ', 'carrollton', 'Carthage', 'Centralia', 'Champaign', 'Charleston', 'Chester', 'Chicago', 'Chicago Heights', 'Clinton', 'Collinsville', 'Crystal Lake', 'Danville', 'Decatur', 'DeKalb', 'Des Plains', 'Dixon', 'East Moline', 'East St Louis', 'Edwardsville', 'Effingham', 'Elgin', 'Eureka', 'Evanston', 'Fairfield', 'Forsuth', 'Freeport', 'Galena', 'Galesburg', 'Granite City', 'Greenville', 'Harrisburg', 'Havana', 'Herrin', 'Highland Park', 'Hillsboro', 'Jacksonville', 'Jerseyville', 'Joliet', 'Jonesboro', 'Kankakee', 'La Salle', 'Lacon', 'Lake Forest', 'Lawrenceville', 'Lewiston', 'Lincoln', 'Macomb', ' Marion', 'Marshall', 'Mattoon', 'McHenry', 'McLeansboro', 'Metropolis', 'Moline', 'Monmouth', 'Monticello', 'Morris', 'Morrison', 'Mount Carmel', 'Mount Carroll', 'Mount Sterling', 'Mount Vernon', 'Murphysboro', 'Naperville', 'Nashville', 'Newton', 'O Fallon', 'Olney', 'Oregon', 'Ottawa', 'Paris', 'Paxton', 'Pekin', 'Peoria', 'Peru', 'Petersburg', 'Pinckneyville', 'Pittsfield', 'Pontiac', 'Princeton', 'Quincy', 'Robinson', 'Rock Falls', 'Rock Island', 'Rockford', 'Rushville', 'St Charles', 'Salem', 'Shawneetown', 'Shelbyville', 'Springfield', 'Sterling', 'Streator', 'Sycamore', 'Taylorville', 'Toulon', 'Tuscola', 'Urbana', 'Vandalia', 'Virginia', 'Washington', 'Waterloo', 'Watseka', 'Waukegan', 'Wheaton', 'Winchester', 'Winnetka', 'Woodstock', 'Zion');
cities['North America']['United States']['Indiana'] = new Array('Select a city', 'Alexandria', 'Anderson', 'Angola', 'Attica', 'Auburn', 'Batesville', 'Bedford', 'Berne', 'Bicknell', 'Bloomington', 'Bluffton', 'Booneville', 'Carmel', 'Charlestown', 'Columbia', 'Columbus', 'Connersville', 'Decatur', 'Delphi', 'East Chicago', 'Elkhart', 'Elwood', 'Evansville', 'Fort Wayne', 'Frankfort', 'Franklin', 'Garrett', 'Gary', 'Gas City', 'Goshen', 'Greencastle', 'Greenfield', 'Greensburg', 'Greenwood', 'Hammond', 'Hartford City', 'Huntingtonburg', 'Huntington', 'Indianapolis', 'Jasper', 'Jeffersonville', 'Kendallville', 'Knox', 'Kokomo', 'Lafayette', 'La Porte', 'Lawrenceburg', 'Lebanon', 'Ligonier', 'Linton', 'Logansport', 'Martinsville', 'Michigan City', 'Mishawaka', 'Mitchell', 'Monticello', 'Mount Vernon', 'Muncie', 'Nappanee', 'New Albany', 'New Castle', 'New Haven', 'Noblesville', 'North Vernon', 'Peru', 'Petersburg', 'Plymouth', 'Portage', 'Portland', 'Princeton', 'Rensselaer', 'Richmond', 'Rising Sun', 'Rochester', 'Rockport', 'Rushville', 'Salem', 'Scottsburg', 'Seymour', 'Shelbyville', 'South Bend', 'Tell City', 'Terre Haute', 'Tipton', 'Union City', 'Valparaiso', 'Vernon', 'Vincennes', 'Wabash', 'Warsaw', 'Washington', 'West Lafayette', 'Winchester');
cities['North America']['United States']['Iowa'] = new Array('Select a city', 'Adel', 'Albia', 'Algona', 'Allison', 'Ames', 'Anamosa', 'Ankeny', 'Atlantic', 'Audubon', 'Bedford', 'Belle Plaine', 'Belmond', 'Bettendorf', 'Bloomfield', 'Boone', 'Burlington', 'Carroll', 'Cedar Falls', 'Cedar Rapids', 'Centerville', 'Chariton', 'Charles City', 'Cherokee', 'Clarinda', 'Clarion', 'Clear Lake', 'Clinton', 'Coralville', 'Corning', 'Corydon', 'Council Bluffs', 'Cresco', 'Creston', 'Dakota City', 'Davenport', 'De Witt', 'Decorah', 'Denison', 'Des Moines', 'Dubuque', 'Dyersville', 'Eagle Grove', 'Eldora', 'Elkader', 'Emmetsburg', 'Estherville', 'Fairfield', 'Forest City', 'Fort Dodge', 'Fort Madison', 'Garner', 'Glenwood', 'Greenfield', 'Grinnell', 'Grundy Center', 'Guthrie Center', 'Hampton', 'Harlan', 'Hawarden', 'Humbolt', 'Ida Grove', 'Independence', 'Indianola', 'Iowa City', 'Iowa Falls', 'Jefferson', 'Keokuk', 'Keosauqua', 'Knoxville', 'Le Mars', 'Leon', 'Logan', 'Manchester', 'Maquoketa', 'Marion', 'Marshalltown', 'Mason City', 'Milford', 'Missouri Valley', 'Montezuma', 'Monticello', 'Mount Ayr', 'Mount Pleasant', 'Mount Vernon', 'Muscatine', 'Nevada', 'New Hampton', 'Newton', 'North Liberty', 'Northwood', 'Oelwein', 'Okoboji', 'Onawa', 'Orange City', 'Osage', 'Osceola', 'Oskaloosa', 'Ottumwa', 'Pacific Junction', 'Pella', 'Perry', 'Pocahontas', 'Primghar', 'Red Oak', 'Rock Rapids', 'Rock Valley', 'Rockwell City', 'Sac City', 'Sheldon', 'Shenandoah', 'Sibly', 'Sidney', 'Sigourney', 'Sioux Center', 'Sioux City', 'Spencer', 'Spirit Lake', 'Storm Lake', 'Story City', 'Tama', 'Tipton', 'Toledo', 'Vinton', 'Wapello', 'Washington', 'Waterloo', 'Waukon', 'Waverly', 'Webster City', 'Webster City', 'West Liberty', 'West Union', 'Williamsburg', 'Wilton', 'Winterset');
cities['North America']['United States']['Kansas'] = new Array('Select a city', 'Abilene', 'Alma', 'Anthony', 'Arkansas', 'Ashland', 'Atchison', 'Atwood', 'Augusta', 'Baldwin City', 'Baxter Springs', 'Belleville', 'Beloit', 'Burlington', 'Caney', 'Chanute', 'Cherryvale', 'Cimarron', 'Clay Center', 'Coffeyville', 'Colby', 'Coldwater', 'Columbus', 'Concordia', 'Cottonwood Falls', 'Council Grove', 'Derby', 'Dighton', 'Dodge City', 'El Dorado', 'Elkhart', 'Ellinwood', 'Ellsworth', 'Emporia', 'Erie', 'Eureka', 'Fort Scott', 'Fredonia', 'Frontenac', 'Garden City', 'Garnett', 'girard', 'Goodland', 'Gove', 'Great Bend', 'Greensburg', 'Hays', 'Herington', 'Hesston', 'Hiawatha', 'Hill City', 'Hillsboro', 'Hoisington', 'Holton', 'Howard', 'Hoxie', 'Hugoton', 'Hutchinson', 'Independence', 'Iola', 'Jetmore', 'Johnson City', 'Junction City', 'Kansas City', 'Kingman', 'Kinsley', 'La Crosse', 'Lakin', 'Larned', 'Lawrence', 'Leavenworth', 'Leoti', 'Liberal', 'Lincoln', 'Louisburg', 'Lyndon', 'Lyons', 'Manhattan', 'Mankato', 'Marion', 'Marysville', 'McPherson', 'Meade', 'Medicine Lodge', 'Minneapolis', 'Mound City', 'Mulvane', 'Neodesha', 'Ness City', 'Newton', 'Norton', 'Oakley', 'Oberlin', 'Olathe', 'Osage City', 'Osawatomie', 'Osborne', 'Oskaloosa', 'Oswego', 'Ottawa', 'Paola', 'Parsons', 'Phillipsburg', 'Pittsburg', 'Plainville', 'Pratt', 'Russell', 'Sabetha', 'St Francis', 'St John', 'St Marys', 'Salina', 'Scott City', 'Sedan', 'Seneca', 'Sharon Springs', 'Shawnee', 'Smith Center', 'South Hutchinson', 'Sterling', 'Stockton', 'Sublette', 'Syracuse', 'Tonganoxie', 'Topeka', 'Tribune', 'Troy', 'Ulysses', 'WaKeeney', 'Wamego', 'Washington', 'Wellington', 'Westmoreland', 'Wichita', 'Winfield', 'Yates Center');
cities['North America']['United States']['Kentucky'] = new Array('Select a city', 'Albany', 'Alexandria', 'Ashland', 'Barbourville', 'Bardstown', 'Beaver Dam', 'Berea', 'Bowling Green', 'Cadiz', 'Campbellsville', 'Carrollton', 'Central City', 'Columbia', 'Corbin', 'Cumberland', 'Cynthiana', 'Danville', 'Dawson Springs', 'Eddyville', 'Elizabethtown', 'Eminence', 'Falmouth', 'Flemingsburg', 'Florence', 'Fort Thomas', 'Frankfort', 'Franklin', 'Fulton', 'Georgetown', 'Glasgow', 'Greensburg', 'Greenville', 'Hardingsburg', 'Harlan', 'Harrodsburg', 'Hartford', 'Hazard', 'Henderson', 'Hickman', 'Hopkinsville', 'Horse Cave', 'Irvine', 'Jackson', 'Jeffersontown', 'Jenks', 'La Grange', 'Lancaster', 'Lawrenceburg', 'Lebanon', 'Leitchfield', 'Lexington', 'London', 'Louisville', 'Madisonville', 'Marion', 'Mayfield', 'Middlesboro', 'Middletown', 'Monticello', 'Morehead', 'Morganfield', 'Morgantown', 'Mount Sterlng', 'Morgantown', 'Mount Sterling', 'Mount Vernon', 'Mount Washington', 'Murray', 'Nicholasville', 'Owensboro', 'Paducah', 'Paintsville', 'Paris', 'Pikeville', 'Pineville', 'Prestonsburg', 'Princeton', 'Providence', 'Radcliff', 'Richmond', 'Russell Springs', 'Russellville', 'Scottsville', 'Shelbyville', 'Shepherdsville', 'Shively', 'Somerset', 'Springfield', 'Stanford', 'Stanton', 'Tompkinsville', 'Versailles', 'West Liberty', 'Williamsburg', 'Williamstown', 'Wilmore', 'Winchester');
cities['North America']['United States']['Louisiana'] = new Array('Select a city', 'Abbeville', 'Alexandria', 'Baton Rouge', 'Bogalusa', 'Bossier City', 'Breaux Bridge', 'Broussard', 'Bunkie', 'Cameron', 'Chalmette', 'Covington', 'Crowley', 'Denham Springs', 'DeQuincy', 'Donaldsonville', 'Edgard', 'Eunice', 'Franklin', 'Gretna', 'Hahnville', 'Hammond', 'Haynesville', 'Houma', 'Iowa', 'Jackson', 'Jeanerette', 'Jennings', 'Kaplan', 'Lake Charles', 'Laplace', 'Leesville', 'Livingston', 'Mamou', 'Mandeville', 'Mansfield', 'Marksville', 'Metairie', 'Minden', 'Monroe', 'Morgan City', 'Natchitoches', 'New Iberia', 'New Orleans', 'New Roads', 'Oakdale', 'Opelousas', 'Patterson', 'Plaquemine', 'Ponchatoula', 'Port Allen', 'Port Sulphur', 'Rayne', 'Ruston', 'St Martinville', 'Scott', 'Shreveport', 'Slidell', 'Springhill', 'Sulphur', 'Tallulah', 'Thibodaux', 'Vidalia', 'Ville Platte', 'Walker', 'West Monroe');
cities['North America']['United States']['Maine'] = new Array('Select a city', 'Auburn', 'Augusta', 'Bangor', 'Belfast', 'Biddeford', 'Brewer', 'Calais', 'Caribou', 'Eastport', 'Ellsworth', 'Gardiner', 'Lewiston', 'Old Town', 'Portland', 'Presque Isle', 'Rockland', 'Saco', 'Sanford', 'South Portland', 'Waterville', 'Westbrook');
cities['North America']['United States']['Maryland'] = new Array('Select a city', 'Aberdeen', 'Annapolis', 'Baltimore', 'Bowie', 'Cockeysville', 'Cumberland', 'Frederick', 'Frostburg', 'Gaithersburg', 'Grasonville', 'Hagerstown', 'Havre de grace', 'Hoopersville', 'Hughesville', 'Ironside', 'Laurel', 'Rockville', 'Salisbury', 'Silver Spring', 'Taneytown', 'Westminster');
cities['North America']['United States']['Massachusetts'] = new Array('Select a city', 'Amesbury', 'Attleboro', 'Beverley', 'Boston', 'Bridgewater', 'Brockton', 'Cambridge', 'Chicopee', 'Clinton', 'Concord', 'Easthampton', 'Everette', 'Fall River', 'Falmouth', 'Fitchburg', 'Foxborough', 'Framingham', 'Gardner', 'Gloucester', 'Greenfield', 'Haverhill', 'Hingham', 'Holyoke', 'Hudson', 'Hyannis', 'Lawrence', 'Leominster', 'Lowell', 'Lynn', 'Marlborough', 'Methuen', 'New Bedford', 'Newburyport', 'Newton', 'North Adams', 'North Amherst', 'Northampton', 'Peabody', 'Pittsfield', 'Quincy', 'Revere', 'Salem', 'Southbridge', 'Spencer', 'Springfield', 'Taunton', 'Topsfield', 'Uxbridge', 'Vineyard Heaven', 'Wakefield', 'Walpole', 'Waltham', 'Ware', 'Wareham center', 'Wayland', 'Webster', 'Wellesley', 'West Bridgewater', 'West Springfield', 'West Yarmouth', 'Woburn', 'Worchester', 'Wrentham');
cities['North America']['United States']['Michigan'] = new Array('Select a city', 'Adrian', 'Albion', 'Allegan', 'Alma', 'Alpena', 'Ann Arbor', 'Bad Axe', 'Battle Creek', 'Bay City', 'Benton Harbor', 'Bessemer', 'Big Rapids', 'Brighton', 'Buchanan', 'Burton', 'Cadillac', 'Caro', 'Charlevoix', 'Charlotte', 'Cheboygan', 'Chelsea', 'Coldwater', 'Corunna', 'Crystal Falls', 'Davison', 'Dearborn', 'Detroit', 'Dowagiac', 'Eaton Rapids', 'Escanaba', 'Fenton', 'Flint', 'Frankenmuth', 'Fremont', 'Gaylord', 'Gladstone', 'Gladwin', 'Grand Haven', 'Grand Ledge', 'Grand Rapids', 'Grayling', 'Greenville', 'Harrison', 'Hart', 'Hastings', 'Hillsdale', 'Holland', 'Houghton', 'Howell', 'Hudsonville', 'Ionia', 'Iron Mountain', 'Ironwood', 'Ishpeming', 'Ithaca', 'Jackson', 'Kalamazoo', 'Lake City', 'Lansing', 'Lapeer', 'Livonia', 'Ludington', 'Mackinaw City', 'Manistee', 'Marine City', 'Marquette', 'Marshall', 'Marysville', 'Mason', 'Menominee', 'Midland', 'Milan', 'Mount Pleasant', 'Munising', 'Muskegon', 'Muskegon', 'Muskegon Heights', 'Negaunee', 'New Baltimore', 'Niles', 'Novi', 'Owosso', 'Petoskey', 'Pontiac', 'Port Huron', 'Portage', 'Reed City', 'Richmond', 'Rockford', 'Rogers City', 'Saginaw', 'St Clair', 'St Ignance', 'St Johns', 'St Joseph', 'St Louis', 'Saline', 'Sandusky', 'Sault Ste Marie', 'South Haven', 'Standish', 'Stanton', 'Sturgis', 'Tawas City', 'Tecumseh', 'Three RIvers', 'Traverse City', 'Trenton', 'Warren', 'West Branch', 'Westland', 'Wyandotte', 'Wyoming', 'Ypsilanti', 'Zeeland');
cities['North America']['United States']['Minnesota'] = new Array('Select a city', 'Ada', 'Aitkin', 'Albert Lea', 'Alexandria', 'Anoka', 'Appleton', 'Austin', 'Bagley', 'Baudette', 'Baxter', 'Becker', 'Belle Plaine', 'Bemidji', 'Benson', 'Benson', 'Big Lake', 'Blaine', 'Bloomington', 'Blue Earth', 'Brainerd', 'Breckenridge', 'Buffalo', 'Caledonia', 'Cambridge', 'Cannon Falls', 'Chaska', 'Chatfield', 'Chisholm', 'Clouqute', 'Cohasset', 'Cokato', 'Crookston', 'Crosby', 'Delano', 'Detroit Lakes', 'Duluth', 'East Grand Forks', 'Eden Prairie', 'Elbow Lake', 'Elk River', 'Eveleth', 'Fairmont', 'Faribault', 'Farmington', 'Fergus Falls', 'Foley', 'Forest Lake', 'Gaylord', 'Glencoe', 'Glenwood', 'Grand Marais', 'Grand Rapids', 'Granite Falls', 'Hallock', 'Hastings', 'Hibbing', 'Hutchinson', 'International Falls', 'Ivanhoe', 'Jackson', 'Jordan', 'Kasson', 'La Crescent', 'Lake City', 'Lake Crystal', 'Lakeville', 'Le Sueur', 'Litchfield', 'Little Falls', 'Long Prairie', 'Luverne', 'Madelia', 'Madison', 'Mahnomen', 'Mankato', 'Marshall', 'Milaca', 'Minneapolis', 'Montevideo', 'Montgomery', 'Monticello', 'Moorhead', 'Moose Lake', 'Mora', 'Morris', 'New Prague', 'New Ulm', 'North Branch', 'Northfield', 'Olivia', 'Ortonville', 'Owatonna', 'Park Rapids', 'Paynesville', 'Pelican Rapids', 'Perham', 'Pine City', 'Pine Island', 'Pipestone', 'Plainview', 'Preston', 'Princeton', 'Raymond', 'Red Lake Falls', 'Red Wing', 'Redwood Falls', 'Rochester', 'Roseau', 'St Cloud', 'St James', 'St Joseph', 'St Paul', 'St Peter', 'Sandstone', 'Sauk Centre', 'Sauk Rapids', 'Shakopee', 'Slayton', 'Sleepy Eye', 'Spring Valley', 'Staples', 'Stewartville', 'Stillwater', 'Thief River Falls', 'Tracy', 'Two Harbors', 'Virginia', 'Wabasha', 'Wadena', 'Walker', 'Warren', 'Waseca', 'Wells', 'Wheaton', 'White Bear Lake', 'Willmar', 'Windom', 'Winona', 'Worthington', 'Zimmerman', 'Zumbrota');
cities['North America']['United States']['Mississippi'] = new Array('Select a city', 'Aberdeen', 'Amory', 'Baldwyn', 'Batesville', 'Bay St Louis', 'Bay Springs', 'Belzoni', 'Biloxi', 'Booneville', 'Brandon', 'Brookhaven', 'Canton', 'Carthage', 'Charleston', 'Clarksdale', 'Cleveland', 'Clinton', 'Columbia', 'Columbus', 'Corinth', 'Crystal Springs', 'D Iberville', 'Drew', 'Durant', 'Eupora', 'Fayette', 'Forest', 'Fulton', 'Gautier', 'Greenville', 'Greenwood', 'Grenada', 'Gulfport', 'Hattiesburg', 'Hazelhurst', 'Hernando', 'Hollandale', 'Holly Springs', 'Horn Lake', 'Houston', 'Itta Bena', 'Iuka', 'Jackson', 'Kosciusko', 'Laurel', 'Leland', 'Lexington', 'Long Beach', 'Louisville', 'Lucedale', 'Lumberton', 'Macon', 'Madison', 'Magee', 'Magnolia', 'Marks', 'McComb', 'Mendenhall', 'Meridian', 'Monticello', 'Morton', 'Moss Point', 'Mound Bayou', 'Natchez', 'Pontotoc', 'Poplarville', 'Port Gibson', 'Purvis', 'Quitman', 'Raymond', 'Richland', 'Ridgeland', 'Ripley', 'Rosedale', 'Ruleville', 'Saltillo', 'Senatobia', 'Shelby', 'Southaven', 'Starkville', 'Vicksburg', 'Water Valley', 'Waynesboro', 'West Point', 'Wiggins', 'Winona', 'Woodville', 'Yazoo City');
cities['North America']['United States']['Missouri'] = new Array('Select a city', 'Aurora', 'Belton', 'Blue Springs', 'Bolivar', 'Bonne Terre', 'Boonville', 'Bowling Green', 'Branson', 'Boonville', 'Bowling Green', 'Branson', 'Brookfield', 'Butler', 'California', 'Cameron', 'Cape Girardeau', 'Carollton', 'Carthage', 'Caruthersville', 'Centralia', 'Charleston', 'Chillicothe', 'Clinton', 'Columbia', 'Crystal City', 'Desoto', 'Dexter', 'El Dorado Springs', 'Eldon', 'Eureka', 'Excelsior Springs', 'Farmington', 'Festus', 'Fredricktown', 'Fulton', 'Gladstone', 'Grandview', 'Hannibal', 'Grandview', 'Hannibal', 'Hollister', 'Independence', 'Jackson', 'Jefferson City', 'Joplin', 'Kearney', 'Kenett', 'Kirksville', 'Kirkwood', 'Lamar', 'Lebanon', 'Lexington', 'Liberty', 'Louisiana', 'Macon', 'Malden', 'Marshall', 'Marshfield', 'Maryville', 'Mexico', 'Moberly', 'Monette', 'Mount Vernon', 'Mountain Grove', 'Neosho', 'Nevada', 'New Madrid', 'Nixa', 'Odessa', 'Osage Beach', 'Ozark', 'Pacific', 'Park Hills', 'PerryVIlle', 'Platte City', 'Pleasant Hill', 'Poplar Bluff', 'Republic', 'Richmond', 'Rolla', 'St Charles', 'St Clair', 'St James', 'St Joseph', 'St Louis', 'Ste Genevieve', 'Salem', 'Savannah', 'Scott City', 'Sedalia', 'Sikeston', 'Springfied', 'Sullivan', 'Trenton', 'Troy', 'Union', 'Vandalia', 'Warrensburg', 'Warrenton', 'Washington', 'Waynesville', 'Webb City', 'Weldon Spring', 'West Plains');
cities['North America']['United States']['Montana'] = new Array('Select a city', 'Anaconda', 'Baker', 'Ballantine', 'Belgrade', 'Big Timber', 'Bigfork', 'Billings', 'Black Eagle', 'Boulder', 'Box Elder', 'Bozeman', 'Butte', 'Cascade', 'Chinook', 'Choteau', 'Clinton', 'Colstrip', 'Columbia Falls', 'Conrad', 'Culbertson', 'Cut Bank', 'Deer Lodge', 'Dillion', 'East Helena', 'Fairview', 'Forsyth', 'Fort Benton', 'Glendive', 'Glendive', 'Great Falls', 'Hamilton', 'Hardin', 'Harlem', 'Harlowton', 'Havre', 'Helena', 'Hot Springs', 'Jefferson City', 'Kalispell', 'Lakeside', 'Laurel', 'Libby', 'Malta', 'Manhattan', 'Miles City', 'Missoula', 'Plentywood', 'Polson', 'Poplar', 'Red Lodge', 'Roberts', 'Ronan', 'Roundup', 'Scobey', 'Shelby', 'Sidney', 'Thompson Falls', 'Three Forks', 'Townsend', 'Troy', 'White Sulphur Springs');
cities['North America']['United States']['Nebraska'] = new Array('Select a city', 'Ainsworth', 'Albion', 'Alliance', 'Alma', 'Arapahoe', 'Ashland', 'Atkinson', 'Auburn', 'Aurora', 'Bassett', 'Bayard', 'Bayard', 'Beatrice', 'Beaver City', 'Bellevue', 'Benkelman', 'Blair', 'Bloomfield', 'Bridgeport', 'Broken Bow', 'Burwell', 'Cambridge', 'Central City', 'Chadron', 'Chappell', 'Clay Center', 'Columbus', 'Cozad', 'Crawford', 'Creighton', 'Crete', 'Dakota City', 'David City', 'Fairbury', 'Falls City', 'Franklin', 'Fremont', 'Friend', 'Fullerton', 'Geneva', ',Geona ', 'Gering', 'Gibbon', 'Gordon', 'Gothenburg', 'Grand Island', 'Grant', 'Hardington', 'Hastings', 'Hebron', 'Holdrege', 'Imperial', 'Kearney', 'Kimball', 'Laurel', 'Lexington', 'Lincoln', 'Louisville', 'Loup City', 'Madison', 'McCook', 'Milford', 'Minden', 'Mitchell', 'Nebraska City', 'Neligh', 'Nelson', 'Norfolk', 'North Bend', 'North Platte', 'O Neill', 'Oakland ', 'Ogallala', 'Omaha', 'Ord', 'Osceola', 'Oshkosh', 'Papillion', 'Pawnee City', 'Pierce', 'Plainview', 'Plattsmouth', 'Ponca', 'Ravenna', 'Red Cloud', 'Rushville', 'St Paul', 'Schuyler', 'Scottsbluff', 'Seward', 'Sidney', 'South Sioux City', 'Stanton', 'Stromsburg', 'Superior', 'Sutton', 'Syracuse', 'Tecumseh', 'Tekamah', 'Tilden', 'Tryon', 'Valentine', 'Valley', 'Wahoo', 'Wakefield', 'Waverly', 'Wayne', 'West point', 'Wilber', 'Winser', 'Wood River', 'Wymore', 'York', 'Yutan');
cities['North America']['United States']['Nevada'] = new Array('Select a city', 'Beatty', 'Boulder City', 'Caliente', 'Carlin', 'Carson City', 'Elko', 'Ely', 'Fallon', 'Fernley', 'Henderson', 'Las Vegas', 'Lovelock', 'Mesquite', 'Reno', 'Silver Springs', 'Sparks', 'Stateline', 'Verdi', 'Virginia City', 'Wadsworth', 'Walker Lake', 'Wells', 'West Wendover', 'Winnemucca', 'Yerington', 'Portsmouth', 'Rochester');
cities['North America']['United States']['New Hampshire'] = new Array('Select a city', 'Berlin', 'Claremont', 'Concord', 'Dover', 'Franklin', 'Kenne', 'Laconia', 'Labonon', 'Manchester', 'Rochester');
cities['North America']['United States']['New Jersey'] = new Array('Select a city');
cities['North America']['United States']['New Mexico'] = new Array('Select a city');
cities['North America']['United States']['New York'] = new Array('Select a city');
cities['North America']['United States']['North Carolina'] = new Array('Select a city');
cities['North America']['United States']['North Dakota'] = new Array('Select a city');
cities['North America']['United States']['Ohio'] = new Array('Select a city');
cities['North America']['United States']['Oklahoma'] = new Array('Select a city', 'Ada', 'Edmond', 'Enid', 'Midwest City', 'Moore', 'Norman', 'Oklahoma City');
cities['North America']['United States']['Oregon'] = new Array('Select a city');
cities['North America']['United States']['Pennsylvania'] = new Array('Select a city');
cities['North America']['United States']['Rhode Island'] = new Array('Select a city');
cities['North America']['United States']['South Carolina'] = new Array('Select a city');
cities['North America']['United States']['South Dakota'] = new Array('Select a city');
cities['North America']['United States']['Tennessee'] = new Array('Select a city', 'Athens', 'Bartlett', 'Bolivar', 'Bristol', 'Brownsville', 'Camden', 'Chattanooga', 'Clarksville', 'Cleveland', 'Clinton', 'Columbia', 'Cookeville', 'Covington', 'Crossville', 'Dayton', 'Dickson', 'Dunlap', 'Dyersburg', 'Elizabethton', 'Etowah', 'Fayetteville', 'Franklin', 'Gallatinburg', 'Goodlettsville', 'Harriman', 'Henderson', 'Hohenwald', 'Humboldt', 'Jackson', 'Jefferson City', 'Johnson City', 'Kingsport', 'Kingston', 'Knoxville', 'La Vergne', 'Lafayette', 'LaFollette', 'Lawrenceburg', 'Lebanon', 'Lenoir City', 'Lewisburg', 'Lexington', 'Loudon', 'Lynchburg', 'Madison', 'Madisonville', 'Manchester', 'Manchester', 'Martin', 'Maryville', 'McKenzie', 'McMinnville', 'Memphis', 'Milan', 'Millington', 'Morristown', 'Mount Pleasant', 'Murfreesboro', 'Nashville', 'Newport', 'Oak Ridge', 'Paris', 'Pigeon Forge', 'Portland', 'Pulaski', 'Ripley', 'Rockwood', 'Savannah', 'Sevierville', 'Sevierville', 'Shelbyville', 'Smithville', 'Soddy-Daisy', 'Sparta', 'Springfield', 'Sweetwater', 'Tallassee', 'Trenton', 'Tullahoma', 'Union City', 'Waverly', 'Winchester');
cities['North America']['United States']['Texas'] = new Array('Select a city');
cities['North America']['United States']['Utah'] = new Array('Select a city');
cities['North America']['United States']['Vermont'] = new Array('Select a city', 'Burlington', 'Montpelier', 'Newport', 'Rutland', 'St Albans', 'Vergennes', 'Winooski', 'Woodstock');
cities['North America']['United States']['Virginia'] = new Array('Select a city');
cities['North America']['United States']['Washington'] = new Array('Select a city');
cities['North America']['United States']['West Virginia'] = new Array('Select a city');
cities['North America']['United States']['Wisconsin'] = new Array('Select a city');
cities['North America']['United States']['Wyoming'] = new Array('Select a city');
// Towns lists
var towns = new Array();
towns['North America'] = new Array();
towns['North America']['Select a country'] = new Array();
towns['North America']['Select a country']['Select a state'] = new Array('Select a town');
towns['North America']['Canada'] = new Array();
towns['North America']['Canada']['Select a territory'] = new Array('Select a town');
towns['North America']['Canada']['Alberta'] = new Array('Select a town', 'Town 1', 'Town 2');
towns['North America']['Canada']['British Columbia'] = new Array('Select a town', 'Town 1', 'Town 2');
towns['North America']['Canada']['Ontario'] = new Array('Select a town', 'Town 1', 'Town 2');

towns['North America']['Mexico'] = new Array();
towns['North America']['Mexico']['Select a federal entity'] = new Array('Select a town');
towns['North America']['Mexico']['Baja California'] = new Array('Select a town', 'Town 1', 'Town 2');
towns['North America']['Mexico']['Chihuahua'] = new Array('Select a town', 'Town 1', 'Town 2');
towns['North America']['Mexico']['Jalisco'] = new Array('Select a town', 'Town 1', 'Town 2');

towns['Europe'] = new Array();
towns['Europe']['Slect a country'] = new Array();
towns['Europe']['Slect a country']['Select a state'] = new Array('Select a city');
towns['Europe']['Spain'] = new Array();
towns['Europe']['Spain']['Select a district'] = new Array('Select a city');
towns['Europe']['Spain']['Galacia'] = new Array('Select a city', 'Lugo', 'vigo');
towns['Europe']['Spain']['Barcelona'] = new Array('Select a city', 'Besal�', 'Cadaqu�s', 'Sitges');

towns['North America']['United States'] = new Array();
towns['North America']['United States']['Select a state'] = new Array('Select a town');
towns['North America']['United States']['Alabama'] = new Array('Select a town', 'Anniston', 'Bessemer', 'Butler', 'Chatom', 'Clayton', 'Double Springs', 'Grovehill', 'Hayneville', 'Hazel Green', 'LaFeyette', 'Leeds', 'Midfield', 'Mobile', 'Rockford');
towns['North America']['United States']['Alaska'] = new Array('Select a town', 'Big Delta', 'Cantwell', 'Circle', 'Circle Hot Springs', 'Cordova', 'Glenallen', 'Iditarod', 'Karluk', 'Livengood', 'Noatak', 'PortGraham', 'Prudhoe Bay', 'Taylor', 'Tok');
towns['North America']['United States']['Arizona'] = new Array('Select a town', 'Ajo', 'Bagdad', 'Bellemont', 'Camp Verde', 'Cave Creek', 'Chino Valley', 'Clarkdale', 'Clifton', 'Colorado City', 'Congress', 'Eagar', 'Huachuca City', 'Kayenta', 'Kearny', 'Marana', 'Miami', 'Payson', 'Pima', 'Pinetop-Lakeside', 'Presscot Valley', 'Quartzsite', 'Sahuarita', 'Snowflake', 'Superior', 'Thatcher', 'Welton', 'Wickenburg');
towns['North America']['United States']['Arkansas'] = new Array('Select a town', 'Arkadelphia', 'Arkansas City', 'Marianna', 'Walnut Ridge');
towns['North America']['United States']['California'] = new Array('Select a town', 'Alturas', 'Apple Valley', 'Borrego Springs', 'Bridgeport', 'Buellton', 'Calexico', 'California City', 'Calipatria', 'Calistoga', 'Camarillo', 'Cambria', 'Downieville', 'Frazier Park', 'Gridley', 'Guerneville', 'Independence', 'Jamestown', 'Los Gatos', 'Lucerne', 'Mammoth Lakes', 'Mariposa', 'Morro Bay', 'Mount Shasta', 'Oakhurst', 'Oildale', 'Paradise', 'Rosamond', 'San Andreas', 'Sonora', 'Susanville', 'Truckee', 'Twain Harte', 'Ventura', 'Visalia', 'Weaverville');
towns['North America']['United States']['Colorado'] = new Array('Select a town', 'Akron', 'Basalt', 'Bennett', 'Buena Vista', 'Carbondale', 'Castle Rock', 'Center', 'Cheyenne Wells', 'Clifton', 'Colorado City', 'Conejos', 'Creede', 'Cripple Creek', 'Del Norte', 'Delta', 'Dove Creek', 'Eads', 'Eagle', 'Eaton', 'Ests Park', 'Fairplay', 'Frederick', 'Fruita', 'Friutvale', 'Georgetown', 'Georgetown', 'Gypsum', 'Hot Sulphur Springs', 'Hugo', 'Julesburg', 'Kiowa', 'Lake City', 'Limon', 'Lincoln Park', 'Littleton', 'Longmont', 'Meeker', 'Monte Vista', 'Montrose', 'Ordway', 'Ouray', 'Parker', 'Pagosa Springs', 'Palisade', 'Parker', 'Penrose', 'Platteville', 'Rangely', 'Saguache', 'Salida', 'San Luis', 'Silverton', 'Springfield', 'Sterling', 'Vail', 'Waldon', 'Windsor');
towns['North America']['United States']['Connecticut'] = new Array('Select a town', 'Avon', 'Baltic', 'Bethal', 'Bloomfield', 'Branford', 'Canaan', 'Cheshire', 'Colchester', 'Columbia', 'Cromwell', 'Dalielson', 'Darien', 'Deep River', 'East Hampton', 'East Hartford', 'East Haven', 'Ellington', 'Fairfield', 'Farmington', 'Georgetown', 'Greenwich', 'Groton', 'Guilford', 'Hamden', 'Kensington', 'Lakeville', 'Litchfield', 'Manchester', 'Middlebury', 'Naugatuck', 'New Cannan', 'New Fairfield', 'New Milford', 'Newington', 'Newtown', 'Norfolk', 'Northford', 'Old Mystic', 'Pawcatuck', 'Plainfield', 'Plainville', 'Plymouth', 'Portland', 'Putnam', 'Ridgefield', 'Seymour', 'Simsbury', 'South Windham', 'South Windham', 'South Windsor', 'South Bury', 'Stafford Springs', 'Storrs', 'Stratford', 'Thomaston', 'Thompsonville', 'Trambull', 'Uncasville', 'Unionville', 'Vernon', 'Weatongue', 'West Hartford', 'Weston', 'Wethersfield', 'Willimantic', 'Wilton', 'Windsor', 'Windsor Locks', 'Winsted');
towns['North America']['United States']['Delaware'] = new Array('Select a town', 'Bethany', 'Bridgeville', 'Claymont', 'Felton', 'Georgetown', 'Glascow', 'Greenwood', 'Laurel', 'Middletown', 'Smyrna');
towns['North America']['United States']['District of Columbia'] = new Array('Select a town', 'Washington');
towns['North America']['United States']['Florida'] = new Array('Select a town', 'Apalachicola', 'Crawfordville', 'Crestview', 'Cross City', 'Dade City', 'Englewood', 'Homosassa', 'Homosassa Springs', 'Immokokalee', 'Jensen Beach', 'Jupiter', 'Kendell', 'Key Largo', 'Lady Lake', 'Lehigh Acres', 'Lutz', 'Middleburg', 'Orange Park', 'Plant City', 'Port Charlotte', 'Port St Joe', 'Yeehaw Junction');
towns['North America']['United States']['Georgia'] = new Array('Select a town', 'Ashburn', 'Lithia Springs', 'Sylvester', 'Washington');
towns['North America']['United States']['Hawaii'] = new Array('Select a town');
towns['North America']['United States']['Idaho'] = new Array('Select a town', 'American Falls', 'Cataldo', 'Chester', 'Elk City', 'Fernwood', 'Hagerman', 'Lava Hot Springs', 'Mackay', 'Malad City', 'Moreland', 'Naples', 'Orofino', 'Pleasantview', 'Silverton', 'Sweet');
towns['North America']['United States']['Illinios'] = new Array('Select a town', 'Normal');
towns['North America']['United States']['Indiana'] = new Array('Select a town', 'Albion', 'Bloomfield', 'Brazil', 'Bremen', 'Brookville', 'Brownsburg', 'Brownstown', 'Cedar Lake', 'Chesterton', 'Clarksville', 'Clinton', 'Corydon', 'Covington', 'Crawfordsville', 'Crown Point', 'Danville', 'DeMotte', 'Edinburgh', 'English', 'Fortville', 'Fowler', 'French Lick', 'Hebron', 'Kentland', 'Lagrange', 'Liberty', 'Lowell', 'Madison', 'Marion', 'Mooresville', 'Nashville', 'Newport', 'North Terre Haute', 'Paoli', 'Pendleton', 'Plainfield', 'Rockville', 'Schererville', 'Sellersburg', 'Shoals', 'Spencer', 'Sullivan', 'Syracuse', 'Verasailles', 'Vevay', 'Westville', 'Williamsport', 'Winamac');
towns['North America']['United States']['Iowa'] = new Array('Select a town', 'Marengo');
towns['North America']['United States']['Kansas'] = new Array('Select a town');
towns['North America']['United States']['Kentucky'] = new Array('Select a town', 'Benton');
towns['North America']['United States']['Louisiana'] = new Array('Select a town', 'Amite', 'Arcadia', 'Baldwin', 'Bastrop', 'Benton', 'Clinton', 'Colfax', 'Columbia', 'Coushatta', 'Delhi', 'DeRidder', 'Farmerville', 'Ferriday', 'Gramercy', 'Greensburg', 'Greenwood', 'Homer', 'Jena', 'Jonesboro', 'Jonesville', 'Lake Arthur', 'Lake Providence', 'Many', 'Oak Grove', 'Oberlin', 'Raceland', 'Rayville', 'St Francisville', 'St Joseph', 'Simmesport', 'Vivian', 'Welsh', 'Winnfield', 'Winnsboro');
towns['North America']['United States']['Maine'] = new Array('Select a town', 'Andover', 'Ashland', 'Bar Harbor', 'Bath', 'Belfast', 'Bethel', 'Bingham', 'Blue Hill', 'Boothbay Harbor', 'Bridgewater', 'Bridgton', 'Brownville Junction', 'Brunswick', 'Bucksport', 'Camden', 'Castine', 'Cherryfield', 'Corinna', 'Cornish', 'Damariscotta', 'Danforth', 'Deer Isle', 'Dexter', 'Dixfield', 'Dover-Foxcroft', 'Eagle Lake', 'East Corinth', 'East Millinocket', 'Fairfield', 'Falmouth', 'Farmington', 'Fort Fairfield', 'Fort Kent', 'Freeport', 'Friendship', 'Fryeburg', 'Gorham', 'Gray', 'Greenville', 'Guliford', 'Hampden', 'Harrington', 'Harrison', 'Houlton', 'Howland', 'Jackman', 'Jones Port', 'Kennebunk', 'Kennebuckport', 'Kingfield', 'Kittery', 'Limestone', 'Lincoln', 'Livermore Falls', 'Lubec ', 'Machias', 'Madison', 'Mars Hill', 'Mattawamkeag', 'Medway', 'Mexico', 'Milbridge', 'Millinocket', 'Milo', 'Monson', 'Monticello', 'Naples', 'Newport', 'North Berwick', 'Norway', 'Ogunquit', 'Old Orchard Beach', 'Orono', 'Patten', 'Phillips', 'Pittsville', 'Poland', 'Port Clyde', 'Princeton', 'Rangeley', 'Rumford', 'Scarborough', 'Searsport', 'Skowhegan', 'Solon', 'South Paris', 'Southwest Harbor', 'Standish', 'Stonington', 'Stratton', 'Thomaston', 'Turner', 'Union', 'Unity', 'Van Buren', 'Vinalhaven', 'Waldaboro', 'Washburn', 'Wells', 'West Enfield', 'West Scarboro', 'Wilton', 'Winslow', 'Winterport', 'Winthrop', 'Woodland', 'Yarmouth', 'York Harbor', 'York Village');
towns['North America']['United States']['Maryland'] = new Array('Select a town', 'Bel Air', 'Bel Alton', 'Beltsville', 'Berlin', 'Bethesda', 'Boonsboro', 'Cambridge', 'Centreville', 'Chesapeake City', 'Chestertown', 'Church Hill', 'Churchville', 'Conowingo', 'Cooksville', 'Corriganville', 'Crisfield', 'Darlington', 'Delmar', 'Denton', 'Easton', 'Edgewood', 'Elkridge', 'Elkton', 'Ellicott City', 'Emmitsburg', 'Federalsburg', 'Flintstone', 'Fort Washington', 'Galena', 'Germantown', 'GoldsBoro', 'Grantsville', 'Hampstead', 'Hancock', 'La Plata', 'La Vale', 'Leonardtown', 'Lexington Park', 'Libertytown', 'Lothian', 'Mount Airy', 'Nanticoke', 'NewBurg', 'Oakland', 'Ocena City', 'Olney', 'Oxford', 'Pocomoke City', 'Princess Anne', 'Queenstown', 'Reisterstown', 'Rhodes Point', 'Ridge', 'Rock Hall', 'Romancoke', 'St Marys City', 'St Michaels', 'Snow Hill', 'Sudlersville', 'Suitland', 'Sunderland', 'Towson', 'Tuscarora', 'Upper Marlboro', 'Waldorf', 'Wenona', 'Westernport', 'Williamsport', 'Woodsboro');
towns['North America']['United States']['Massachusetts'] = new Array('Select a town', 'Adams', 'Amherst', 'Andover', 'Athol', 'Aburn', 'Ayer', 'Barnstable', 'Bedford', 'Belchertown', 'Bellingham', 'Billerica', 'Briantree', 'Brewster', 'Brookline', 'Buzzards Bay', 'Cohasset', 'Concord', 'Dalton', 'Danvers', 'Dartmouth', 'Dedham', 'Dennis', 'East Douglas', 'East Falmouth', 'East Longmeadow', 'East Pepperell', 'Edgartown', 'Fairhaven', 'Foxborough', 'Georgetown', 'Great Barrington', 'Harwich', 'Harwichport', 'Holden', 'Holliston', 'Hyannis', 'Ipswich', 'Kingston', 'Lee', 'Leicester', 'Lexington', 'Lincoln', 'Longmeadow', 'Lunenburg', 'Lynnfield', 'Mansfield', 'MarbleHead', 'Marshfield', 'Maynard', 'Medfield', 'Middleborough', 'Middleton', 'Milford', 'Millis', 'Nantucket', 'Natick', 'North Andover', 'North Attleboro', 'North Brookfield', 'Norton', 'Norwood', 'Oak Bluffs', 'Orange', 'Orleans', 'Oxford', 'Palmer', 'Plymouth', 'Provincetown', 'Randolph', 'Rockland', 'Rockport', 'Rutland', 'Salisbury', 'Sandwich', 'Saugus', 'Scituate', 'Sharon', 'Shelburne Falls', 'Shrewsbury', 'Smith Mills', 'Somerset', 'South Deerfield', 'South Hadley', 'Southampton', 'Stoneham', 'Sturbridge', 'Sudbury', 'Swampscott', 'Westfield', 'Whitman', 'Wilbraham', 'Williamstown', 'Wilmington', 'Winchendon');
towns['North America']['United States']['Michigan'] = new Array('Select a town', 'Atlanta', 'Benton Heights', 'Bertrand', 'Eagle River', 'Leland', 'Manistique', 'Michigan Center', 'Mio', 'Monroe', 'Mount Clemens', 'Waterford');
towns['North America']['United States']['Minnesota'] = new Array('Select a town');
towns['North America']['United States']['Mississippi'] = new Array('Select a town', 'Ackerman', 'Ashland', 'Belmont', 'Brooksville', 'Bruce', 'Calhoun City', 'Centreville', 'Coffeeville', 'Collins', 'Como', 'De Kalb', 'Decatur', 'Edwards', 'Ellisville', 'Flora', 'Florence', 'Indianola', 'Lambert', 'Leakesville', 'Liberty', 'Meadville', 'Nettleton', 'New Albany', 'Newton', 'Ocean Spring', 'Okolona', 'Olive Branch', 'Oxford', 'Pascagoula', 'Pass Christian', 'Pearl', 'Petal', 'Philadelphia', 'Picayune', 'Pickens', 'Prentiss', 'Raleigh', 'Rolling Fork', 'Sardis', 'Saucier', 'Shannon', 'Shaw', 'Summit', 'Taylorsville', 'Tchula', 'Tunica', 'Tupelo', 'Tutwiler', 'Tylertown', 'Union', 'Vaiden', 'Vancleave', 'Wesson');
towns['North America']['United States']['Missouri'] = new Array('Select a town', 'Harrisonville', 'Villa Ridge');
towns['North America']['United States']['Montana'] = new Array('Select a town', 'Abssarokee', 'Alberton', 'Arlee', 'Ashland', 'Augusta', 'Belt', 'Big Sandy', 'Bridger', 'Broadus', 'Browning', 'Chester', 'Circle', 'Clyde Park', 'Columbus', 'Crow Agency', 'Denton', 'Drummond', 'Dutton', 'Ekalaka', 'Ennis', 'Eureka', 'Fairfield', 'Florence', 'Frazer', 'Frenchtown', 'Gallatin Gateway', 'Gardiner', 'Geraldine', 'Hungry Horse', 'Huntley', 'Hysham', 'Joliet', 'Jordan', 'Lewistown', 'Lincoln', 'Livingston', 'Lodge Grass', 'Lolo', 'Nashua', 'Philipsburg', 'Plains', 'Ryegate', 'St Ignatius', 'Savage', 'Sheridan', 'Somers', 'St Regis Montana', 'Stanford', 'Stevensville', 'Sunburst', 'Superior', 'Terry', 'Twin Bridges', 'Ulm', 'Valier', 'vaugh', 'Voctor', 'Virgina City', 'Walkerville', 'West Yellostone', 'Whitefish', 'Whitehall', 'Wibaux', 'Winnett', 'Wolf Point');
towns['North America']['United States']['Nebraska'] = new Array('Select a town', 'Butte', 'Harrisburg');
towns['North America']['United States']['Nevada'] = new Array('Select a town', 'Alamo', 'Amargosa', 'Battle Mountain', 'Beatty', 'Dayton', 'Eureka', 'Garnerville', 'Hawthorne', 'Indian Springs', 'Jackpot', 'Laughlin', 'Logandale', 'McGill', 'Minden', 'Overton', 'Owhhee', 'Pahrump', 'Panaca', 'Pioche', 'Schurz', 'Searchlight', 'Tonopah', 'Walker Lake');
towns['North America']['United States']['New Hampshire'] = new Array('Select a town', 'Bristol', 'Conway', 'Derry', 'Durham', 'Enfield', 'Epping', 'Exeter', 'Farmington', 'Goffstown', 'Gorham', 'Hampton', 'Hanover', 'Henniker', 'Hudson', 'Lancaster', 'Littleton', 'Meredith', 'Merrimac', 'Milford', 'Nashua', 'Newport', 'North Hampton', 'Ossipee', 'Peterborough', 'Pittsfield', 'Plymouth', 'Salem', 'Swanzey', 'Winchester', 'Wolfeboro');
towns['North America']['United States']['New Jersey'] = new Array('Select a town');
towns['North America']['United States']['New Mexico'] = new Array('Select a town');
towns['North America']['United States']['New York'] = new Array('Select a town');
towns['North America']['United States']['North Carolina'] = new Array('Select a town');
towns['North America']['United States']['North Dakota'] = new Array('Select a town');
towns['North America']['United States']['Ohio'] = new Array('Select a town');
towns['North America']['United States']['Oklahoma'] = new Array('Select a town', 'Harrah', 'Achillie', 'Adair', 'Nicoma Park');
towns['North America']['United States']['Oregon'] = new Array('Select a town');
towns['North America']['United States']['Pennsylvania'] = new Array('Select a town');
towns['North America']['United States']['Rhode Island'] = new Array('Select a town');
towns['North America']['United States']['South Carolina'] = new Array('Select a town');
towns['North America']['United States']['South Dakota'] = new Array('Select a town');
towns['North America']['United States']['Tennessee'] = new Array('Select a town', 'Ashland City', 'Centerville', 'Collierville', 'Erwin', 'Farragut', 'Greeneville', 'Huntingdon', 'Livingston', 'Oneida', 'Rogersville', 'Selmer', 'Signal Mountain', 'Smyrna', 'Tellico Plains', 'Whiteville');
towns['North America']['United States']['Texas'] = new Array('Select a town');
towns['North America']['United States']['Utah'] = new Array('Select a town');
towns['North America']['United States']['Vermont'] = new Array('Select a town', 'Arlington', 'Barre', 'Bennington', 'Bethel', 'Brandon', 'Brattleboro', 'Chelsea', 'Fair Haven', 'Guildhall', 'Hardwick', 'Hyde Park', 'Johnson', 'Manchester', 'Manchester', 'Middlebury', 'Newfane', 'North Hero', 'Northfield', 'Norwich', 'Poultney', 'Proctor', 'Putney', 'Randolph', 'St Johnsbury', 'South Barre', 'South Burlington', 'Springfield', 'Swanton', 'Waterbury', 'Windsor');
towns['North America']['United States']['Virginia'] = new Array('Select a town');
towns['North America']['United States']['Washington'] = new Array('Select a town');
towns['North America']['United States']['West Virginia'] = new Array('Select a town');
towns['North America']['United States']['Wisconsin'] = new Array('Select a town');
towns['North America']['United States']['Wyoming'] = new Array('Select a town');


// Village lists
var villages = new Array();
villages['North America'] = new Array();
villages['North America']['Select a country'] = new Array();
villages['North America']['Select a country']['Select a state'] = new Array('Select a city');
villages['North America']['Select a country']['Select a state']['Select a city'] = new Array('Select a village');

villages['North America']['Canada'] = new Array();
villages['North America']['Canada']['Select a territory'] = new Array('Select a city');
villages['North America']['Canada']['Select a territory']['Select a city']  = new Array('Select a village');
villages['North America']['Canada']['Alberta']['Select a city']             = new Array('Select a village');
villages['North America']['Canada']['Alberta']['Edmonton']                  = new Array('Select a village');
villages['North America']['Canada']['Alberta']['Calgary']                   = new Array('Select a village');
villages['North America']['Canada']['British Columbia']['Select a city']    = new Array('Select a village');
villages['North America']['Canada']['British Columbia']['Victoria']         = new Array('Select a village');
villages['North America']['Canada']['British Columbia']['Vancouver']        = new Array('Select a village');
villages['North America']['Canada']['Ontario']['Select a city']             = new Array('Select a village');
villages['North America']['Canada']['Ontario']['Toronto']                   = new Array('Select a village');
villages['North America']['Canada']['Ontario']['Hamilton']                  = new Array('Select a village');

villages['North America']['Mexico'] = new Array();
villages['North America']['Mexico']['Select a federal entity']    = new Array('Select a city');
villages['North America']['Mexico']['Select a federal entity']['Select a city']     = new Array('Select a village');
villages['North America']['Mexico']['Baja California']['Select a city']             = new Array('Select a village');
villages['North America']['Mexico']['Baja California']['Tijauna']                   = new Array('Select a village');
villages['North America']['Mexico']['Baja California']['Mexicali']                  = new Array('Select a village');
villages['North America']['Mexico']['Chihuahua']['Select a city']                   = new Array('Select a village');
villages['North America']['Mexico']['Chihuahua']['Ciudad Ju�rez']                   = new Array('Select a village');
villages['North America']['Mexico']['Chihuahua']['Chihuahua']                       = new Array('Select a village');
villages['North America']['Mexico']['Jalisco']['Select a city']                     = new Array('Select a village');
villages['North America']['Mexico']['Jalisco']['Guadalajara']                       = new Array('Select a village');
villages['North America']['Mexico']['Jalisco']['Chapala']                           = new Array('Select a village');

villages['Europe'] = new Array();
villages['Europe']['Select a country'] = new Array();
villages['Europe']['Select a country']['Select a state'] = new Array('Select a city');
villages['Europe']['Select a country']['Select a state']['Select a city'] = new Array('Select a village');
villages['Europe']['Spain'] = new Array();
villages['Europe']['Spain']['Select a district'] = new Array('Select a city');
villages['Europe']['Spain']['Select a district']['Select a city']   = new Array('Select a village');
villages['Europe']['Spain']['Galacia']['Select a city']             = new Array('Select a village');
villages['Europe']['Spain']['Galacia']['A Corona']                  = new Array('Select a village');
villages['Europe']['Spain']['Galacia']['Ferrol']                    = new Array('Select a village');
villages['Europe']['Spain']['Barcelona']['Select a city']           = new Array('Select a village');
villages['Europe']['Spain']['Barcelona']['Barcalona']               = new Array('Select a village');

villages['North America']['United States'] = new Array();
villages['North America']['United States']['Select a state'] = new Array('Select a city');
villages['North America']['United States']['Select a state']['Select a city']           = new Array('Select a village');
villages['North America']['United States']['Alabama']['Select a city']                  = new Array('Select a village');
villages['North America']['United States']['Alabama']['Montgomery']                     = new Array('Select a village');
villages['North America']['United States']['Alaska']['Select a city']                   = new Array('Select a village');
villages['North America']['United States']['Alaska']['Anchorage']                       = new Array('Select a village');
villages['North America']['United States']['Alaska']['Juneau']                          = new Array('Select a village');
villages['North America']['United States']['Arizona']['Select a city']                  = new Array('Select a village');
villages['North America']['United States']['Arkansas']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['California']['Select a city']               = new Array('Select a village');
villages['North America']['United States']['Colorado']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['Connecticut']['Select a city']              = new Array('Select a village');
villages['North America']['United States']['Delaware']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['District of Columbia']['Select a city']     = new Array('Select a village');
villages['North America']['United States']['District of Columbia']['District of Columbia'] = new Array('Select a village');
villages['North America']['United States']['Florida']['Select a city']                  = new Array('Select a village');
villages['North America']['United States']['Georgia']['Select a city']                  = new Array('Select a village');
villages['North America']['United States']['Hawaii']['Select a city']                   = new Array('Select a village');
villages['North America']['United States']['Idaho']['Select a city']                    = new Array('Select a village');
villages['North America']['United States']['Illinios']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['Indiana']['Select a city']                  = new Array('Select a village');
villages['North America']['United States']['Iowa']['Select a city']                     = new Array('Select a village');
villages['North America']['United States']['Kansas']['Select a city']                   = new Array('Select a village');
villages['North America']['United States']['Kentucky']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['Louisiana']['Select a city']                = new Array('Select a village');
villages['North America']['United States']['Maine']['Select a city']                    = new Array('Select a village');
villages['North America']['United States']['Maryland']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['Massachusetts']['Select a city']            = new Array('Select a village');
villages['North America']['United States']['Michigan']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['Minnesota']['Select a city']                = new Array('Select a village');
villages['North America']['United States']['Mississippi']['Select a city']              = new Array('Select a village');
villages['North America']['United States']['Missouri']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['Montana']['Select a city']                  = new Array('Select a village');
villages['North America']['United States']['Nebraska']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['Nevada']['Select a city']                   = new Array('Select a village');
villages['North America']['United States']['New Hampshire']['Select a city']            = new Array('Select a village');
villages['North America']['United States']['New Jersey']['Select a city']               = new Array('Select a village');
villages['North America']['United States']['New Mexico']['Select a city']               = new Array('Select a village');
villages['North America']['United States']['New York']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['North Carolina']['Select a city']           = new Array('Select a village');
villages['North America']['United States']['North Dakota']['Select a city']             = new Array('Select a village');
villages['North America']['United States']['Ohio']['Select a city']                     = new Array('Select a village');
villages['North America']['United States']['Oklahoma']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['Oklahoma']['Ada']                           = new Array('Select a village', 'village1', 'village2');
villages['North America']['United States']['Oklahoma']['Edmond']                        = new Array('Select a village', 'village3', 'village4');
villages['North America']['United States']['Oklahoma']['Enid']                          = new Array('Select a village', 'village5', 'village6');
villages['North America']['United States']['Oklahoma']['Midwest City']                  = new Array('Select a village', 'village7', 'village8');
villages['North America']['United States']['Oklahoma']['Moore']                         = new Array('Select a village', 'village9', 'village10');
villages['North America']['United States']['Oklahoma']['Norman']                        = new Array('Select a village', 'village11', 'village12');
villages['North America']['United States']['Oklahoma']['Oklahoma City']                 = new Array('Select a village', 'village13', 'village14');
villages['North America']['United States']['Oregon']['Select a city']                   = new Array('Select a village');
villages['North America']['United States']['Pennsylvania']['Select a city']             = new Array('Select a village');
villages['North America']['United States']['Rhode Island']['Select a city']             = new Array('Select a village');
villages['North America']['United States']['South Carolina']['Select a city']           = new Array('Select a village');
villages['North America']['United States']['South Dakota']['Select a city']             = new Array('Select a village');
villages['North America']['United States']['Tennessee']['Select a city']                = new Array('Select a village');
villages['North America']['United States']['Texas']['Select a city']                    = new Array('Select a village');
villages['North America']['United States']['Utah']['Select a city']                     = new Array('Select a village');
villages['North America']['United States']['Vermont']['Select a city']                  = new Array('Select a village');
villages['North America']['United States']['Virginia']['Select a city']                 = new Array('Select a village');
villages['North America']['United States']['Washington']['Select a city']               = new Array('Select a village');
villages['North America']['United States']['West Virginia']['Select a city']            = new Array('Select a village');
villages['North America']['United States']['Wisconsin']['Select a city']                = new Array('Select a village');
villages['North America']['United States']['Wyoming']['Select a city']                  = new Array('Select a village');

// Island lists (city)
var islands = new Array();
islands['North America'] = new Array();
islands['North America']['Select a country'] = new Array();
islands['North America']['Select a country']['Select a state'] = new Array('Select a city');
islands['North America']['Select a country']['Select a state']['Select a city'] = new Array('Select an island');

islands['North America']['Canada'] = new Array();
islands['North America']['Canada']['Select a territory'] = new Array('Select a city');
islands['North America']['Canada']['Select a territory']['Select a city']  = new Array('Select an island');
islands['North America']['Canada']['Alberta']['Select a city']             = new Array('Select an island');
islands['North America']['Canada']['Alberta']['Edmonton']                  = new Array('Select an island');
islands['North America']['Canada']['Alberta']['Calgary']                   = new Array('Select an island');
islands['North America']['Canada']['British Columbia']['Select a city']    = new Array('Select an island');
islands['North America']['Canada']['British Columbia']['Victoria']         = new Array('Select an island');
islands['North America']['Canada']['British Columbia']['Vancouver']        = new Array('Select an island');
islands['North America']['Canada']['Ontario']['Select a city']             = new Array('Select an island');
islands['North America']['Canada']['Ontario']['Toronto']                   = new Array('Select an island');
islands['North America']['Canada']['Ontario']['Hamilton']                  = new Array('Select an island');

islands['North America']['Mexico'] = new Array();
islands['North America']['Mexico']['Select a federal entity']    = new Array('Select a city');
islands['North America']['Mexico']['Select a federal entity']['Select a city']     = new Array('Select an island');
islands['North America']['Mexico']['Baja California']['Select a city']             = new Array('Select an island');
islands['North America']['Mexico']['Baja California']['Tijauna']                   = new Array('Select an island');
islands['North America']['Mexico']['Baja California']['Mexicali']                  = new Array('Select an island');
islands['North America']['Mexico']['Chihuahua']['Select a city']                   = new Array('Select an island');
islands['North America']['Mexico']['Chihuahua']['Ciudad Ju�rez']                   = new Array('Select an island');
islands['North America']['Mexico']['Chihuahua']['Chihuahua']                       = new Array('Select an island');
islands['North America']['Mexico']['Jalisco']['Select a city']                     = new Array('Select an island');
islands['North America']['Mexico']['Jalisco']['Guadalajara']                       = new Array('Select an island');
islands['North America']['Mexico']['Jalisco']['Chapala']                           = new Array('Select an island');

islands['Europe'] = new Array();
islands['Europe']['Select a country'] = new Array();
islands['Europe']['Select a country']['Select a state'] = new Array('Select a city');
islands['Europe']['Select a country']['Select a state']['Select a city'] = new Array('Select an island');
islands['Europe']['Spain'] = new Array();
islands['Europe']['Spain']['Select a district'] = new Array('Select a city');
islands['Europe']['Spain']['Select a district']['Select a city']   = new Array('Select an island');
islands['Europe']['Spain']['Galacia']['Select a city']             = new Array('Select an island');
islands['Europe']['Spain']['Galacia']['A Corona']                  = new Array('Select an island');
islands['Europe']['Spain']['Galacia']['Ferrol']                    = new Array('Select an island');
islands['Europe']['Spain']['Barcelona']['Select a city']           = new Array('Select an island');
islands['Europe']['Spain']['Barcelona']['Barcalona']               = new Array('Select an island');

islands['North America']['United States'] = new Array();
islands['North America']['United States']['Select a state'] = new Array('Select a city');
islands['North America']['United States']['Select a state']['Select a city']           = new Array('Select an island');
islands['North America']['United States']['Alabama']['Select a city']                  = new Array('Select an island');
islands['North America']['United States']['Alabama']['Montgomery']                     = new Array('Select an island');
islands['North America']['United States']['Alaska']['Select a city']                   = new Array('Select an island');
islands['North America']['United States']['Alaska']['Anchorage']                       = new Array('Select an island');
islands['North America']['United States']['Alaska']['Juneau']                          = new Array('Select an island');
islands['North America']['United States']['Arizona']['Select a city']                  = new Array('Select an island');
islands['North America']['United States']['Arkansas']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['California']['Select a city']               = new Array('Select an island');
islands['North America']['United States']['Colorado']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['Connecticut']['Select a city']              = new Array('Select an island');
islands['North America']['United States']['Delaware']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['District of Columbia']['Select a city']     = new Array('Select an island');
islands['North America']['United States']['District of Columbia']['District of Columbia'] = new Array('Select an island');
islands['North America']['United States']['Florida']['Select a city']                  = new Array('Select an island');
islands['North America']['United States']['Georgia']['Select a city']                  = new Array('Select an island');
islands['North America']['United States']['Hawaii']['Select a city']                   = new Array('Select an island');
islands['North America']['United States']['Idaho']['Select a city']                    = new Array('Select an island');
islands['North America']['United States']['Illinios']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['Indiana']['Select a city']                  = new Array('Select an island');
islands['North America']['United States']['Iowa']['Select a city']                     = new Array('Select an island');
islands['North America']['United States']['Kansas']['Select a city']                   = new Array('Select an island');
islands['North America']['United States']['Kentucky']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['Louisiana']['Select a city']                = new Array('Select an island');
islands['North America']['United States']['Maine']['Select a city']                    = new Array('Select an island');
islands['North America']['United States']['Maryland']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['Massachusetts']['Select a city']            = new Array('Select an island');
islands['North America']['United States']['Michigan']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['Minnesota']['Select a city']                = new Array('Select an island');
islands['North America']['United States']['Mississippi']['Select a city']              = new Array('Select an island');
islands['North America']['United States']['Missouri']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['Montana']['Select a city']                  = new Array('Select an island');
islands['North America']['United States']['Nebraska']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['Nevada']['Select a city']                   = new Array('Select an island');
islands['North America']['United States']['New Hampshire']['Select a city']            = new Array('Select an island');
islands['North America']['United States']['New Jersey']['Select a city']               = new Array('Select an island');
islands['North America']['United States']['New Mexico']['Select a city']               = new Array('Select an island');
islands['North America']['United States']['New York']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['North Carolina']['Select a city']           = new Array('Select an island');
islands['North America']['United States']['North Dakota']['Select a city']             = new Array('Select an island');
islands['North America']['United States']['Ohio']['Select a city']                     = new Array('Select an island');
islands['North America']['United States']['Oklahoma']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['Oklahoma']['Ada']                           = new Array('Select a island', 'island1', 'island2');
islands['North America']['United States']['Oklahoma']['Edmond']                        = new Array('Select a island', 'island3', 'island4');
islands['North America']['United States']['Oklahoma']['Enid']                          = new Array('Select a island', 'island5', 'island6');
islands['North America']['United States']['Oklahoma']['Midwest City']                  = new Array('Select a island', 'island7', 'island8');
islands['North America']['United States']['Oklahoma']['Moore']                         = new Array('Select a island', 'island9', 'island10');
islands['North America']['United States']['Oklahoma']['Norman']                        = new Array('Select a island', 'island11', 'island12');
islands['North America']['United States']['Oklahoma']['Oklahoma City']                 = new Array('Select a island', 'island13', 'island14');
islands['North America']['United States']['Oregon']['Select a city']                   = new Array('Select an island');
islands['North America']['United States']['Pennsylvania']['Select a city']             = new Array('Select an island');
islands['North America']['United States']['Rhode Island']['Select a city']             = new Array('Select an island');
islands['North America']['United States']['South Carolina']['Select a city']           = new Array('Select an island');
islands['North America']['United States']['South Dakota']['Select a city']             = new Array('Select an island');
islands['North America']['United States']['Tennessee']['Select a city']                = new Array('Select an island');
islands['North America']['United States']['Texas']['Select a city']                    = new Array('Select an island');
islands['North America']['United States']['Utah']['Select a city']                     = new Array('Select an island');
islands['North America']['United States']['Vermont']['Select a city']                  = new Array('Select an island');
islands['North America']['United States']['Virginia']['Select a city']                 = new Array('Select an island');
islands['North America']['United States']['Washington']['Select a city']               = new Array('Select an island');
islands['North America']['United States']['West Virginia']['Select a city']            = new Array('Select an island');
islands['North America']['United States']['Wisconsin']['Select a city']                = new Array('Select an island');
islands['North America']['United States']['Wyoming']['Select a city']                  = new Array('Select an island');



function setCountries() {
    ctinentSel = document.getElementById('continent');
    countryList = countries[ctinentSel.value];
    changeSelect('country', countryList, countryList);
    setStates();
}

function setStates() {
    ctinentSel = document.getElementById('continent');
    cntrySel = document.getElementById('country');
    stateList = states[ctinentSel.value][cntrySel.value];
    changeSelect('state', stateList, stateList);
    setCities();
    setTowns();
}

function setCities() {
    ctinentSel = document.getElementById('continent');
    cntrySel = document.getElementById('country');
    stateSel = document.getElementById('state');
    cityList = cities[ctinentSel.value][cntrySel.value][stateSel.value];
    changeSelect('city', cityList, cityList);
    setVillages();
    setIslands();
}

function setTowns() {
    ctinentSel = document.getElementById('continent');
    cntrySel = document.getElementById('country');
    stateSel = document.getElementById('state');
    townList = towns[ctinentSel.value][cntrySel.value][stateSel.value];
    changeSelect('town', townList, townList);
}

function setVillages() {
    ctinentSel = document.getElementById('continent');
    cntrySel = document.getElementById('country');
    stateSel = document.getElementById('state');
    citySel = document.getElementById('city');
    villageList = villages[ctinentSel.value][cntrySel.value][stateSel.value][citySel.value];
    changeSelect('village', villageList, villageList);
}

function setIslands() {
    ctinentSel = document.getElementById('continent');
    cntrySel = document.getElementById('country');
    stateSel = document.getElementById('state');
    citySel = document.getElementById('city');
    islandList = islands[ctinentSel.value][cntrySel.value][stateSel.value][citySel.value];
    changeSelect('island', islandList, islandList);
}

function changeSelect(fieldID, newOptions, newValues) {
    selectField = document.getElementById(fieldID);
    selectField.options.length = 0;
    for (i = 0; i < newOptions.length; i++) {
        selectField.options[selectField.length] = new Option(newOptions[i], newValues[i]);
    }
}

function addLoadEvent(func) {
    var oldonload = window.onload;
    if (typeof window.onload != 'function') {
        window.onload = func;
    } else {
        window.onload = function () {
            if (oldonload) {
                oldonload();
            }
            func();
        }
    }
}

addLoadEvent(function () {
    setCountries();
});