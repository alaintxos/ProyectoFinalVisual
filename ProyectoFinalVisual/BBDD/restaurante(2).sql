-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 12-03-2020 a las 09:49:08
-- Versión del servidor: 10.4.6-MariaDB
-- Versión de PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `restaurante`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `IdProducto` int(3) NOT NULL,
  `Nombre` varchar(30) COLLATE utf8_bin NOT NULL,
  `Gluten` int(1) NOT NULL,
  `Lactosa` int(1) NOT NULL,
  `Cantidad` int(2) NOT NULL,
  `Precio` int(2) NOT NULL,
  `Descripcion` varchar(500) COLLATE utf8_bin NOT NULL,
  `Orden` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`IdProducto`, `Nombre`, `Gluten`, `Lactosa`, `Cantidad`, `Precio`, `Descripcion`, `Orden`) VALUES
(1, 'Pizza Margarita', 1, 1, 1, 12, 'Es una pizza de origen italiano', 1),
(2, 'Pizza Carbonara', 1, 1, 1, 15, 'Una riquisima pizza con nata y bacon junto a un sabor de cebolla', 1),
(3, 'Pizza barbacoa', 1, 1, 1, 15, 'Una riquisima pizza con bbq, bacon y ternera junto a extra de queso mozarella', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservas`
--

CREATE TABLE `reservas` (
  `IdReserva` int(4) NOT NULL,
  `Nombre` varchar(20) COLLATE utf8_bin NOT NULL,
  `Telefono` int(9) NOT NULL,
  `Numero` int(2) NOT NULL,
  `Fecha` varchar(10) COLLATE utf8_bin NOT NULL,
  `Hora` varchar(5) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `reservas`
--

INSERT INTO `reservas` (`IdReserva`, `Nombre`, `Telefono`, `Numero`, `Fecha`, `Hora`) VALUES
(1, 'Alain Manso', 687663609, 4, '0000-00-00', '00:00'),
(2, 'David Salgado', 687558471, 8, '13/03/2020', ':'),
(3, 'Alain Manso ruiz', 687663609, 3, '10/03/2020', '13:15'),
(4, 'Alain Manso', 687448502, 5, '11/03/2020', '14:30'),
(5, 'ALain', 687669691, 3, '12/03/2020', '13:15'),
(6, 'Alain', 687458471, 15, '12/03/2020', '13:15');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`IdProducto`);

--
-- Indices de la tabla `reservas`
--
ALTER TABLE `reservas`
  ADD PRIMARY KEY (`IdReserva`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `IdProducto` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `reservas`
--
ALTER TABLE `reservas`
  MODIFY `IdReserva` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
