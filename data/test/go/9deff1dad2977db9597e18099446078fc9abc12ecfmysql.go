package cf_mysql_broker 
/*
* File Generated by enaml generator
* !!! Please do not edit this file !!!
*/
type CfMysql struct {

	/*Mysql - Descr: Size of the ib_log_file used by innodb, in MB Default: 1024
*/
	Mysql *Mysql `yaml:"mysql,omitempty"`

	/*Broker - Descr: Optional, The ip to be registered with the cf router for the broker. Defaults to the ip of the vm Default: <nil>
*/
	Broker *Broker `yaml:"broker,omitempty"`

	/*ExternalHost - Descr: Host used to register a route for the broker with the router in cf-release via NATS. By registering the broker with Cloud Foundry using this route, and using the router for load balancing, the broker can be horizontally scaled. Domain is typically the same as system domain in cf-release. Default: <nil>
*/
	ExternalHost interface{} `yaml:"external_host,omitempty"`

	/*Host - Descr: Host (DNS) or IP address used by the broker and bound applications to reach the service Default: <nil>
*/
	Host interface{} `yaml:"host,omitempty"`

}