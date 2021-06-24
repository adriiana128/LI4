CREATE DATABASE photravel;

use photravel;

create table Users (
	Id int unique,
	Email varchar(120) not null,
	Username varchar(100) not null,
	Passw varchar(120) not null,
	Token varchar(512),
	constraint PK_USERS primary key (Id)
);


create table Place (
	Id int unique,
	Score int,
	Addresses varchar(120),
	constraint PK_PLACE primary key (Id)
);


create table Post (
	Id int unique,
	Score int,
	UserId int not null,
	PlaceId int not null,
	PhotoUrl varchar(512),
	Details varchar(512),
	constraint PK_POST primary key (Id),
	constraint FK_POST_REFERENCE_USERS foreign key (UserId) references Users (Id),
	constraint FK_POST_REFERENCE_PLACE foreign key (PlaceId) references Place (Id)
);

create table Commentary (
	Id int unique,
	Comment varchar(512) not null,
	PostId int not null,
	Score int,
	constraint PK_COMMENTARY primary key (Id),
	constraint FK_COMMENTARY_REFERENCE_POST foreign key (PostId) references Post (Id)
);
