-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 23 avr. 2021 à 07:44
-- Version du serveur :  8.0.21
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : gestionpersonnel
--
CREATE DATABASE IF NOT EXISTS gestionpersonnel DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;

CREATE USER 'gestionpersonnel'@'%' IDENTIFIED BY 'mathieu';
GRANT USAGE ON *.* TO 'gestionpersonnel'@'%';
GRANT ALL PRIVILEGES ON `gestionpersonnel`.* TO 'gestionpersonnel'@'%';

USE gestionpersonnel;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  IDPERSONNEL int NOT NULL,
  DATEDEBUT datetime NOT NULL,
  IDMOTIF int NOT NULL,
  DATEFIN datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (IDPERSONNEL, DATEDEBUT, IDMOTIF, DATEFIN) VALUES
(2, '2020-01-02 08:00:00', 3, '2020-01-05 17:00:00'),
(2, '2020-02-02 08:00:00', 2, '2020-02-05 17:00:00'),
(2, '2020-03-02 08:00:00', 3, '2020-03-05 17:00:00'),
(2, '2020-04-02 08:00:00', 4, '2020-04-05 17:00:00'),
(4, '2020-11-15 08:00:00', 1, '2020-11-16 16:00:00'),
(4, '2020-11-17 08:00:00', 1, '2020-11-18 18:00:00'),
(4, '2020-11-19 08:00:00', 2, '2020-11-20 17:00:00'),
(4, '2020-11-21 08:00:00', 2, '2020-11-22 17:00:00'),
(4, '2020-11-25 08:00:00', 2, '2020-11-28 17:00:00'),
(5, '2020-01-10 08:00:00', 1, '2020-01-12 17:00:00'),
(5, '2020-02-10 08:00:00', 1, '2020-02-12 19:00:00'),
(5, '2020-03-10 08:00:00', 4, '2020-03-12 17:00:00'),
(5, '2020-04-10 08:00:00', 2, '2020-04-12 17:00:00'),
(6, '2020-01-11 08:00:00', 1, '2020-01-15 17:00:00'),
(6, '2020-02-12 08:00:00', 2, '2020-02-20 17:00:00'),
(6, '2020-03-15 08:00:00', 3, '2020-03-18 17:00:00'),
(6, '2020-04-20 08:00:00', 4, '2020-04-23 17:00:00'),
(6, '2020-06-15 08:30:00', 4, '2020-07-15 19:30:00'),
(6, '2020-12-14 08:00:00', 3, '2020-12-18 17:00:00'),
(7, '2020-01-14 08:00:00', 2, '2020-01-15 17:00:00'),
(7, '2020-02-16 08:00:00', 1, '2020-02-17 17:00:00'),
(7, '2020-08-18 08:00:00', 2, '2020-08-19 17:00:00'),
(7, '2020-09-23 09:00:00', 3, '2020-09-25 20:00:00'),
(7, '2020-12-01 10:00:00', 4, '2020-12-01 12:00:00'),
(7, '2020-12-07 08:00:00', 1, '2020-12-10 18:00:00'),
(7, '2020-12-15 08:00:00', 2, '2020-12-23 17:00:00'),
(8, '2020-07-15 08:00:00', 3, '2020-07-18 17:00:00'),
(8, '2020-09-15 08:00:00', 1, '2020-09-18 17:00:00'),
(8, '2020-10-15 08:00:00', 4, '2020-10-18 17:00:00'),
(9, '2020-01-20 08:00:00', 3, '2020-01-27 17:00:00'),
(10, '2020-01-20 08:00:00', 3, '2020-01-27 17:00:00');

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  IDMOTIF int NOT NULL,
  LIBELLE varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (IDMOTIF, LIBELLE) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  IDPERSONNEL int NOT NULL,
  IDSERVICE int NOT NULL,
  NOM varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRENOM varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  TEL varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  MAIL varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (IDPERSONNEL, IDSERVICE, NOM, PRENOM, TEL, MAIL) VALUES
(1, 1, 'magee', 'sonia', '0629216488', 'sonia.magee@gestionpersonnel.com'),
(2, 1, 'daquan', 'zoe', '0690000878', 'zoe.daquan@gestionpersonnel.com'),
(3, 1, 'tanner', 'jenette', '0690318595', 'jenette.tanner@gestionpersonnel.com'),
(4, 3, 'malcolm', 'mollie', '0669417665', 'mollie.malcolm@gestionpersonnel.com'),
(5, 3, 'gemma', 'shoshana', '0680333716', 'shoshana.gemma@gestionpersonnel.com'),
(6, 3, 'cedric', 'margaret', '0636496341', 'margaret.cedric@gestionpersonnel.com'),
(7, 2, 'rhiannon', 'evelyn', '0695718915', 'evelyn.rhiannon@gestionpersonnel.com'),
(8, 2, 'clark', 'indira', '0618947342', 'indira.clark@gestionpersonnel.com'),
(9, 3, 'tatyana', 'hilary', '0659490797', 'hilary.tatyana@gestionpersonnel.com'),
(10, 2, 'lewis', 'lael', '0676396355', 'lael.lewis@gestionpersonnel.com');

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  pwd varchar(64) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('responsable', '1ad656e5760e5fe19e9464397685a22dede512bfad2521458b192ea1abaa1ef9');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE service (
  IDSERVICE int NOT NULL,
  NOM varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (IDSERVICE, NOM) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (IDPERSONNEL,DATEDEBUT),
  ADD KEY FK_ABSENCE_MOTIF (IDMOTIF);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (IDMOTIF);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (IDPERSONNEL),
  ADD KEY FK_PERSONNEL_SERVICE (IDSERVICE);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (IDSERVICE);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY IDMOTIF int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY IDPERSONNEL int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY IDSERVICE int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table absence
--
ALTER TABLE absence
  ADD CONSTRAINT absence_ibfk_1 FOREIGN KEY (IDMOTIF) REFERENCES motif (IDMOTIF),
  ADD CONSTRAINT absence_ibfk_2 FOREIGN KEY (IDPERSONNEL) REFERENCES personnel (IDPERSONNEL);

--
-- Contraintes pour la table personnel
--
ALTER TABLE personnel
  ADD CONSTRAINT personnel_ibfk_1 FOREIGN KEY (IDSERVICE) REFERENCES service (IDSERVICE);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
