# .NetCore-WebAPI - Vehicle,Car,Buses,Boats Class (Extend)<br />
.NetCore Post,Get,Delete with Postman Example<br />

Postman Request<br />

[GET] https://localhost:44385/allvehicle/<br />
[GET] https://localhost:44385/cars/<br />
[GET] https://localhost:44385/cars/red<br />
[GET] https://localhost:44385/boats/<br />
[GET] https://localhost:44385/boats/blue<br />
[GET] https://localhost:44385/buses/<br />
[GET] https://localhost:44385/buses/black<br />

[POST] https://localhost:44385/cars/onoff/<br />
//Body(Raw-JSON)
{
	"CarID":2,
    "Headlights":"Far Açık"
}
<hr />
[DELETE] https://localhost:44385/cars/delete
//Body(Raw-JSON)
{
	"CarID":2
}
<br />
