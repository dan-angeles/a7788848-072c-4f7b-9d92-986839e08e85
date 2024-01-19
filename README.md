# Get Longest Sequence
Greetings!

This is a Single Page Application built with Reactjs and .Net Core 7.
This application generates a string output with the longest increasing subsequence (increased by any number) 
parsed from its input sequence. This application runs on a docker linux container with a WSL 2 at its backend.

Prerequisites:
Docker installation
WSL installation

Instructions on loading the application:

1. Peform checkout on the repository from Github.
2. Open a commandline terminal and go to the working directory where the repository has been downloaded to.
3. Produce an SSL certificate by running the commands below:

	dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\codingEx.pfx -p Pass1234
	dotnet dev-certs https --trust
	Note: changing the values are not required for this implementation
4. In the same directory, run this command: docker-compose build
5. Then, run this command: docker-compose up
6. Once the server is up, open a browser and go to this url: https://localhost:44428