# Super simple SOAP server

## Node server that exposes a single endpoint

As time goes by I forget some of details regarding SOAP envelopes. 
Here is a simple server, where I can use a proxy like NGrok to inspect http traffic.

``` yaml
# Ngrok tunnel definition 
SOAP:
    proto: http
    addr: 8001
    host_header: rewrite
    domain: somedomain.ngrok-free.app
```
