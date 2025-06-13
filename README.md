-- Tabel Admin
CREATE TABLE Admin (
    id_admin SERIAL PRIMARY KEY,
    password VARCHAR(16) NOT NULL
);

-- Tabel Pasien
CREATE TABLE Pasien (
    id_pasien SERIAL PRIMARY KEY,
    nama_pasien VARCHAR(50) NOT NULL,
    tanggal_lahir VARCHAR(50) NOT NULL,
    jenis_kelamin CHAR(1) NOT NULL,
    alamat TEXT,
    nomor_ruang INTEGER,
    no_telepon VARCHAR(16)
);

-- Tabel Kondisi
CREATE TABLE Kondisi (
    id_kondisi SERIAL PRIMARY KEY,
    id_pasien INTEGER NOT NULL,
    suhu_tubuh INTEGER,
    tanggal_pengecekan TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    detak_jantung INTEGER,
    tekanan_darah INTEGER,
    nomor_kamar INTEGER,
    FOREIGN KEY (id_pasien) REFERENCES Pasien(id_pasien)
);

-- Tabel Obat
CREATE TABLE Obat (
    id_obat SERIAL PRIMARY KEY,
    nama_obat VARCHAR(50) NOT NULL,
    dosis VARCHAR(25) NOT NULL,
    jenis_obat VARCHAR(25) NOT NULL
);

-- Tabel Penjadwalan Obat
CREATE TABLE Penjadwalan_Obat (
    id_jadwal SERIAL PRIMARY KEY,
    id_pasien INTEGER NOT NULL,
    id_obat INTEGER NOT NULL,
    waktu_pemberian TIMESTAMP NOT NULL,
    waktu_minum TIMESTAMP,
    status VARCHAR(16),
    catatan TEXT,
    FOREIGN KEY (id_pasien) REFERENCES Pasien(id_pasien),
    FOREIGN KEY (id_obat) REFERENCES Obat(id_obat)
);

-- Tabel Laporan
CREATE TABLE Laporan (
    id_laporan SERIAL PRIMARY KEY,
    id_pasien INTEGER NOT NULL,
    id_admin INTEGER NOT NULL,
    tanggal DATE DEFAULT CURRENT_DATE,
    isi_laporan TEXT,
    jenis_laporan VARCHAR(50),
    FOREIGN KEY (id_pasien) REFERENCES Pasien(id_pasien),
    FOREIGN KEY (id_admin) REFERENCES Admin(id_admin)
);

-- Data awal Admin
INSERT INTO Admin (id_admin, password) VALUES 
(1, 'admin123'), 
(2, 'secure456');
