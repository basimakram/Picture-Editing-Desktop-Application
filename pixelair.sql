create Database pixelair;

CREATE TABLE userInfo (
    firstname varchar(50),
	lastname varchar(50),
	username varchar(50),
	email varchar(50),
	gender varchar(50),
    pass varchar(50)
);

INSERT into userInfo Values('Basim', 'Akram', 'basimakram','basimakram@pixelair.com','Male', 'pixelair123')

Select *From userInfo

