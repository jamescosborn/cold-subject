# Cold Subject  
#### No affiliation with Hot Topic  

Congratulations! The Web Design team at MantiCorp have hired you to QA Test their newest website: Cold Subject. Founded by Swiss fashion pioneers and brothers Marco and Bjorn Buchwalder, Cold Subject is a household name in Scandinavia. Now they're looking to make a big splash in the US. Selling everything from Dog Sleds to Folk Singer T Shirts, Cold Subject is bound to be the next big thing. Get a cup of coffee and settle in, because this is it!

Cold Subject's brand new website has full functionality for:  
* A landing page  
* A list of Products  
* Product details: __Cost__, __Description__, __Name__  
* Users can add reviews to products  
* Review detail: __Author__, __ContentBody__, __Rating__  
* Tests for products
* Tests for reviews
* Tests for controllers

## Getting Started

To start the website, you'll need the following:

* A command prompt (Terminal or GitBash recommended)
* A web browser (Chrome recommended)
* A local server environment (MAMP recommended)

### Installation Steps

1. In your command prompt, enter:  
  `git clone https://github.com/jamescosborn/cold-subject.git`
2. Start your SQL server on MAMP.
3. Navigate to the folder with the .csproj in it and enter:   
`dotnet restore`  
`dotnet ef migrations add CodeReview`     
`dotnet ef database update`  
4. Enter:  `dotnet run`
5. In a web browser, navigate to http://localhost:5000 (if the command prompt displays a different local host number, enter that one)

### Technologies Used

* Terminal  
* Git  
* GitHub   
* Chrome  
* Atom  
* C#  
* Visual Studio  
* MAMP

## Scheduled Updates

* None

## Known Bugs

* Multiple test folders appear in the project solution.

## Contributors

James Carl Osborn  
jamescarlosborn@gmail.com  

## Project Specs

| Description        | Input:           | Output:  |
| ------------- |:-------------:| -----:|
| User is greeted with a landing page       | http://localhost:5000       | Welcome to Cold Subject!    |
| User can view a list of products       | click on Product List       | A list of all our products is displayed    |
| User can click on a product to view details       | click on Dog Sled       | view Dog Sled's details    |
| Products details have 4 parts: __Name__, __Cost__, __Description__, and __Reviews__       |  click on Dog Sled       | Name: Dog Sled, Cost: $30, Description: A sled for dogs!, Reviews: 7 reviews  |
| User can add a review to a Product  |  Click on Add Review  | User gets add Review skill  |
| Review details have 3 parts: __Author__, __ContentBody__, __Rating__ | click on Review A  | Author: Bob, ContentBody: Dog Sled is the best, Rating: 5  |

## Technical Specs

* Product tests:     
  -the constructor  
  -Equals()  
  -Method for returning an average Rating  

  __METHODS:__  

  -`GetAll()`  
  -`Save()`  
  -`Update()`  
  -`Delete()`  
  -`DeleteAll()`  

* Review tests:  
  -the constructor  
  -Equals()  
  -Method for checking if rating is between 1-5  
  -Method for checking if the Review's `content_body` contains less than 255 characters  

  __METHODS:__  

  -`GetAll()`  
  -`Save()`  


## License

This project is licensed under the MIT License.

## Acknowledgments

Thank you to my teachers, fellow students, friends, family and pets for your continued support and inspiration.  
