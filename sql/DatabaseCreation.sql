DROP DATABASE IF EXISTS carrentalsystem;
CREATE DATABASE IF NOT EXISTS carrentalsystem;

USE carrentalsystem;
# REVOKE ALL ON `carrentalsystem`.*  FROM `carrentalsystem`@`localhost`;
FLUSH PRIVILEGES;
DROP USER IF EXISTS `admin`@`localhost`;
CREATE USER `admin`@`localhost` IDENTIFIED BY 'Password1';
GRANT USAGE ON `carrentalsystem`.* TO `admin`@`localhost` REQUIRE NONE;
GRANT ALL PRIVILEGES ON `carrentalsystem`.* TO `admin`@`localhost` WITH GRANT OPTION;
FLUSH PRIVILEGES;

DROP TABLE IF EXISTS vehicles;
CREATE TABLE vehicles(
vehicle_id 				INT(11) 		UNSIGNED 				AUTO_INCREMENT PRIMARY KEY,
manufacturer			VARCHAR(25)	DEFAULT 'UNKNOWN'		NOT NULL,
model 					VARCHAR(25) DEFAULT 'UNKNOWN' 	NOT NULL,
make_year 				INT(11) 		DEFAULT '1970' 		NOT NULL,
registration_number	INT(24)		DEFAULT '0101010101'	NOT NULL,
odometer_reading		INT(11)		DEFAULT '0'				NOT NULL,
tank_capacity			INT(11)		DEFAULT '25'			NOT NULL,
date_added  DATETIME DEFAULT '1970-01-01 00:00:00',
date_modified  DATETIME DEFAULT '1970-01-01 00:00:00'
);

INSERT INTO vehicles
	(manufacturer, model, make_year, registration_number, odometer_reading, tank_capacity, date_added, date_modified)
VALUES
	("Ford", "T812", 2014, 1000000000, 25000, 120, NOW(), NOW());