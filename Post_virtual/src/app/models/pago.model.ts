export interface Pago {
    idPago: number;
    idUsuarioSolicitante: number;
    idUsuarioReceptor: number;
    fechaSolicitud: string;
    monto: number;
    estatus: string;
    referencia?: string;
}
