drop table Categorie cascade constraint;
drop table Joueur cascade constraint;
drop table Questions cascade constraint;
drop table Reponse cascade constraint;
drop table Score cascade constraint;



CREATE TABLE Categorie
  (
    CodeCategorie CHAR (1) NOT NULL ,
    NomCategorie  VARCHAR2 (30) ,
    Couleur       VARCHAR2 (20)
  ) ;
ALTER TABLE Categorie ADD CONSTRAINT Categorie_PK PRIMARY KEY ( CodeCategorie ) ;

CREATE TABLE Joueur
  (
    ALIAS  VARCHAR2 (20) NOT NULL ,
    Nom    VARCHAR2 (40) ,
    Prenom VARCHAR2 (40)
  ) ;
ALTER TABLE Joueur ADD CONSTRAINT Joueur_PK PRIMARY KEY ( ALIAS ) ;

CREATE TABLE Questions
  (
    NumQuestion   CHAR (8) NOT NULL ,
    Enoncer       VARCHAR2 (80) ,
    Flag          CHAR (1) ,
    CodeCategorie CHAR (1) NOT NULL
  ) ;
ALTER TABLE Questions ADD CONSTRAINT Questions_PK PRIMARY KEY ( NumQuestion ) ;

CREATE TABLE Reponse
  (
    NumReponse  CHAR (8) NOT NULL ,
    Description VARCHAR2 (60) ,
    EstBonne    CHAR (1) ,
    NumQuestion CHAR (8) NOT NULL
  ) ;
ALTER TABLE Reponse ADD CONSTRAINT Reponse_PK PRIMARY KEY ( NumReponse ) ;

CREATE TABLE Score
  (
    CodeCategorie CHAR (1) NOT NULL ,
    ALIAS         VARCHAR2 (20) NOT NULL ,
    NumParti      NUMBER (10) NOT NULL
  ) ;
ALTER TABLE Score ADD CONSTRAINT Score_PK PRIMARY KEY ( CodeCategorie, ALIAS, NumParti ) ;

ALTER TABLE Questions ADD CONSTRAINT Questions_Categorie_FK FOREIGN KEY ( CodeCategorie ) REFERENCES Categorie ( CodeCategorie ) ;

ALTER TABLE Reponse ADD CONSTRAINT Reponse_Questions_FK FOREIGN KEY ( NumQuestion ) REFERENCES Questions ( NumQuestion ) ;

ALTER TABLE Score ADD CONSTRAINT Score_Categorie_FK FOREIGN KEY ( CodeCategorie ) REFERENCES Categorie ( CodeCategorie ) ;

ALTER TABLE Score ADD CONSTRAINT Score_Joueur_FK FOREIGN KEY ( ALIAS ) REFERENCES Joueur ( ALIAS ) ;


insert into Categorie Values ('B','Geographie','Bleu');
insert into Categorie Values ('V','Science','Vert');
insert into Categorie Values ('J','Histoire','Jaune');
insert into Categorie Values ('O','Sport','Orange');
insert into Categorie Values ('R','Art','Rouge');
insert into Categorie Values ('P','Divertissement','Rose');
commit;
rollback;
select * from Categorie;


