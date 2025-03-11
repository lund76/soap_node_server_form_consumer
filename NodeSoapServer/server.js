const http = require('http');
const fs = require('fs');
const soap = require('soap');

// Define the service with its operations.
const service = {
  MyService: {
    MyServicePort: {
      // Simple implementation of GetData operation.
      GetData: function(args) {
        console.log("Received GetData with", args);
        // Return a result as defined in the WSDL.
        return { result: `You entered: ${args.value}` };
      }
    }
  }
};

// Read the WSDL file.
const wsdlXML = fs.readFileSync('service.wsdl', 'utf8');

// Create an HTTP server.
const server = http.createServer(function(request, response) {
  response.end("404: Not Found: " + request.url);
});

// Start the server on a chosen port.
const port = 8001;
server.listen(port, function() {
  console.log(`Server listening on port ${port}`);
  
  // Use the soap library to attach the SOAP service to our HTTP server.
  soap.listen(server, '/Service.svc', service, wsdlXML);
  console.log(`SOAP service initialized at http://localhost:${port}/Service.svc`);
});
