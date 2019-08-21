-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 22, 2019 at 06:57 PM
-- Server version: 5.5.47
-- PHP Version: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_perlengkapan`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `kd_barang` varchar(8) NOT NULL,
  `nm_barang` varchar(100) NOT NULL,
  `jenis` varchar(30) NOT NULL,
  `stok` int(11) NOT NULL,
  `satuan` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`kd_barang`, `nm_barang`, `jenis`, `stok`, `satuan`) VALUES
('BRG00001', 'Almamater D3', 'Pakaian Seragam', 119, 'Bungkus');

-- --------------------------------------------------------

--
-- Table structure for table `barang_keluar`
--

CREATE TABLE `barang_keluar` (
  `no_keluar` varchar(16) NOT NULL,
  `tgl_keluar` date NOT NULL,
  `nim` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `barang_keluar_detail`
--

CREATE TABLE `barang_keluar_detail` (
  `no` int(11) NOT NULL,
  `no_keluar` varchar(16) NOT NULL,
  `kd_barang` varchar(8) NOT NULL,
  `jml_keluar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_keluar_detail`
--

INSERT INTO `barang_keluar_detail` (`no`, `no_keluar`, `kd_barang`, `jml_keluar`) VALUES
(19, '2019032312072701', 'BRG00001', 2),
(20, '2019032312093901', 'BRG00001', 2),
(21, '2019032312104101', 'BRG00001', 2),
(22, '2019032312104101', 'BRG00001', 2),
(23, '2019032312140601', 'BRG00001', 3),
(24, '2019032312140601', 'BRG00001', 5),
(25, '2019032312175801', 'BRG00001', 3),
(26, '2019032312190201', 'BRG00001', 2),
(27, '2019032312214801', 'BRG00001', 3),
(28, '2019032312241801', 'BRG00001', 3),
(29, '2019032312241801', 'BRG00001', 7),
(30, '2019032312264801', 'BRG00001', 1),
(31, '2019032312264801', 'BRG00001', 2);

-- --------------------------------------------------------

--
-- Table structure for table `barang_masuk`
--

CREATE TABLE `barang_masuk` (
  `struk` varchar(16) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `id_supplier` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_masuk`
--

INSERT INTO `barang_masuk` (`struk`, `tgl_masuk`, `id_supplier`) VALUES
('2019032312133601', '2019-03-23', 'SP000001'),
('2019032312140601', '2019-03-23', '1802208'),
('2019032312175801', '2019-03-23', '1802208');

-- --------------------------------------------------------

--
-- Table structure for table `barang_masuk_detail`
--

CREATE TABLE `barang_masuk_detail` (
  `no` int(11) NOT NULL,
  `struk` varchar(16) NOT NULL,
  `kd_barang` varchar(8) NOT NULL,
  `jml_masuk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_masuk_detail`
--

INSERT INTO `barang_masuk_detail` (`no`, `struk`, `kd_barang`, `jml_masuk`) VALUES
(4, '2019032201164601', 'BRG00001', 2),
(16, '2019032202004801', 'BRG00001', 2),
(17, '2019032202024301', 'BRG00001', 2),
(18, '2019032202024301', 'BRG00001', 2),
(19, '2019032312133601', 'BRG00001', 3),
(20, '2019032312133601', 'BRG00001', 3);

-- --------------------------------------------------------

--
-- Table structure for table `jurusan`
--

CREATE TABLE `jurusan` (
  `kd_jurusan` varchar(8) NOT NULL,
  `nama` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jurusan`
--

INSERT INTO `jurusan` (`kd_jurusan`, `nama`) VALUES
('JRS00001', 'Sistem Informasi'),
('JRS00002', 'Teknik Informasi'),
('JRS00003', 'Manajemen Informasi'),
('JRS00004', 'Komputer Akuntansi');

-- --------------------------------------------------------

--
-- Table structure for table `kelas`
--

CREATE TABLE `kelas` (
  `kd_kelas` varchar(8) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `sesi` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`kd_kelas`, `nama`, `sesi`) VALUES
('KLS00001', 'Sistem Informasi', 'Malam'),
('KLS00002', 'Komputer Akuntansi', 'Malam');

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `nim` varchar(8) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `tmp_lahir` varchar(100) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `agama` varchar(30) NOT NULL,
  `kelamin` varchar(30) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `telp` varchar(13) NOT NULL,
  `jurusan` varchar(100) NOT NULL,
  `kd_kelas` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mahasiswa`
--

INSERT INTO `mahasiswa` (`nim`, `nama`, `tmp_lahir`, `tgl_lahir`, `agama`, `kelamin`, `alamat`, `telp`, `jurusan`, `kd_kelas`) VALUES
('1802208', 'Patar Simbolon', 'Pematangsiantar', '1994-05-16', 'Katolik', 'Laki-Laki', 'Jalan Medan Km 5 Pematangsiantar', '081264124653', 'Sistem Informasi', 'KLS00001');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `id_supplier` varchar(8) NOT NULL DEFAULT '',
  `nm_supplier` varchar(30) NOT NULL DEFAULT '',
  `almt_supplier` varchar(100) NOT NULL DEFAULT '',
  `tlp_supplier` varchar(12) NOT NULL DEFAULT ''
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`id_supplier`, `nm_supplier`, `almt_supplier`, `tlp_supplier`) VALUES
('SP000001', 'sfsf', 'sfs', '5641651');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(25) NOT NULL,
  `password` varchar(50) NOT NULL,
  `user_type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `user_type`) VALUES
('admins', 'YWRtaW5z', 'Administrator');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`kd_barang`);

--
-- Indexes for table `barang_keluar`
--
ALTER TABLE `barang_keluar`
  ADD PRIMARY KEY (`no_keluar`);

--
-- Indexes for table `barang_keluar_detail`
--
ALTER TABLE `barang_keluar_detail`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `barang_masuk`
--
ALTER TABLE `barang_masuk`
  ADD PRIMARY KEY (`struk`);

--
-- Indexes for table `barang_masuk_detail`
--
ALTER TABLE `barang_masuk_detail`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `jurusan`
--
ALTER TABLE `jurusan`
  ADD PRIMARY KEY (`kd_jurusan`);

--
-- Indexes for table `kelas`
--
ALTER TABLE `kelas`
  ADD PRIMARY KEY (`kd_kelas`);

--
-- Indexes for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`nim`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang_keluar_detail`
--
ALTER TABLE `barang_keluar_detail`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `barang_masuk_detail`
--
ALTER TABLE `barang_masuk_detail`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
