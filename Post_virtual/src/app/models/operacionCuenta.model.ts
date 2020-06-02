export interface OperacionCuenta {
    idOperacionCuenta: number;
    idCuenta: number;
    idUsuarioReceptor: number;
    fecha: string;
    hora: string;
    monto: number;
    referencia: string;
}
