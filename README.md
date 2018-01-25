# Cold Subject  
#### No affiliation with Hot Topic.  

Congratulations! The Web Design team at Manticore Corp. has decided to let you QA Test their newest website. Hot diggity dog, you are excited! Get a cup of hot coffee and settle in, because you're in for it.  

Cold Subject's new website has full functionality for:  
* A landing page  
* A list of Products  
* Product details(4): ProductId, Cost, Description, Name  
* Users can add reviews to products  
* Review details(5): ReviewId, Author, ContentBody, ProductId, Rating  
* Tests for products
* Tests for reviews
* Tests for controllers

## Getting Started

Startup Instructions for the app.

### Technologies Used

Git  
github  
Atom  

## Scheduled Updates

* Add Reviews to products
* Product Tests  
* Review Tests  
* Controller Tests  

Anything else?

## Known Bugs

* No known bugs at this time.

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

* Thank you to my teachers, fellow students, friends, family and pets for your continued support and inspiration.  
