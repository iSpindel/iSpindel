import { IDataPoint } from '../classes/Data/IDataPoint';
import { IDataSeries } from '../classes/Data/IDataSeries';

const linetype = "line";

export const tempPoints: IDataPoint[] =
    [
        { x: new Date(2017, 0, 7), y: 25.4 },
        { x: new Date(2017, 0, 14), y: 22.7 },
        { x: new Date(2017, 0, 21), y: 24.9 },
        { x: new Date(2017, 0, 28), y: 38.0 },
        { x: new Date(2017, 1, 4), y: 23.4 },
        { x: new Date(2017, 1, 11), y: 29.9 },
        { x: new Date(2017, 1, 18), y: 28.9 },
        { x: new Date(2017, 1, 25), y: 26.3 },
        { x: new Date(2017, 2, 4), y: 22.7 },
        { x: new Date(2017, 2, 11), y: 20.2 },
        { x: new Date(2017, 2, 18), y: 27.3 },
        { x: new Date(2017, 2, 25), y: 28.5 }
    ];

export const tempSeries: IDataSeries = {
    type: linetype,
    name: "Temperature",
    color: "#369EAD",
    showInLegend: true,
    axisYIndex: 0,
    dataPoints: [
        { x: new Date(2017, 0, 7), y: 25.4 },
        { x: new Date(2017, 0, 14), y: 22.7 },
        { x: new Date(2017, 0, 21), y: 24.9 },
        { x: new Date(2017, 0, 28), y: 38.0 },
        { x: new Date(2017, 1, 4), y: 23.4 },
        { x: new Date(2017, 1, 11), y: 29.9 },
        { x: new Date(2017, 1, 18), y: 28.9 },
        { x: new Date(2017, 1, 25), y: 26.3 },
        { x: new Date(2017, 2, 4), y: 22.7 },
        { x: new Date(2017, 2, 11), y: 20.2 },
        { x: new Date(2017, 2, 18), y: 27.3 },
        { x: new Date(2017, 2, 25), y: 28.5 }
    ]
};

export const tiltSeries: IDataSeries = {
    type: linetype,
    name: "Tilt",
    color: "#C24642",
    axisYIndex: 0,
    axisYType: "secondary",
    showInLegend: true,
    dataPoints: [
        { x: new Date(2017, 0, 7), y: 32.3 },
        { x: new Date(2017, 0, 14), y: 33.9 },
        { x: new Date(2017, 0, 21), y: 26.0 },
        { x: new Date(2017, 0, 28), y: 15.8 },
        { x: new Date(2017, 1, 4), y: 18.6 },
        { x: new Date(2017, 1, 11), y: 4.6 },
        { x: new Date(2017, 1, 18), y: 7.7 },
        { x: new Date(2017, 1, 25), y: 24.7 },
        { x: new Date(2017, 2, 4), y: 35.9 },
        { x: new Date(2017, 2, 11), y: 12.8 },
        { x: new Date(2017, 2, 18), y: 58.1 },
        { x: new Date(2017, 2, 25), y: 62.4 }
    ],
};

export const batteryPoints: IDataPoint[] = [
    { x: new Date(2017, 0, 7), y: 2.5 },
    { x: new Date(2017, 0, 14), y: 4.3 },
    { x: new Date(2017, 0, 21), y: 8.7 },
    { x: new Date(2017, 0, 28), y: 2.5 },
    { x: new Date(2017, 1, 4), y: 5.6 },
    { x: new Date(2017, 1, 11), y: 5.7 },
    { x: new Date(2017, 1, 18), y: 4.6 },
    { x: new Date(2017, 1, 25), y: 12.0 },
    { x: new Date(2017, 2, 4), y: 23.9 },
    { x: new Date(2017, 2, 11), y: 36.4 },
    { x: new Date(2017, 2, 18), y: 40.3 },
    { x: new Date(2017, 2, 25), y: 54.2 },
    { x: new Date(2017, 2, 27), y: 64.2 },
    { x: new Date(2017, 2, 28), y: 74.2 },
    { x: new Date(2017, 2, 29), y: 100 }
];

export const batterySeries: IDataSeries = {
    type: linetype,
    name: "Battery",
    color: "#7F6084",
    axisYIndex: 1,
    showInLegend: true,
    dataPoints: [
        { x: new Date(2017, 0, 7), y: 2.5 },
        { x: new Date(2017, 0, 14), y: 4.3 },
        { x: new Date(2017, 0, 21), y: 8.7 },
        { x: new Date(2017, 0, 28), y: 2.5 },
        { x: new Date(2017, 1, 4), y: 5.6 },
        { x: new Date(2017, 1, 11), y: 5.7 },
        { x: new Date(2017, 1, 18), y: 4.6 },
        { x: new Date(2017, 1, 25), y: 12.0 },
        { x: new Date(2017, 2, 4), y: 23.9 },
        { x: new Date(2017, 2, 11), y: 36.4 },
        { x: new Date(2017, 2, 18), y: 40.3 },
        { x: new Date(2017, 2, 25), y: 54.2 },
        { x: new Date(2017, 2, 27), y: 64.2 },
        { x: new Date(2017, 2, 28), y: 74.2 },
        { x: new Date(2017, 2, 29), y: 100 }
    ],
};

export const gravityPoints: IDataPoint[] = [
    { x: new Date(2017, 0, 7), y: 18.5 },
    { x: new Date(2017, 0, 14), y: 20.3 },
    { x: new Date(2017, 0, 21), y: 17.7 },
    { x: new Date(2017, 0, 28), y: 15.5 },
    { x: new Date(2017, 1, 4), y: 10.6 },
    { x: new Date(2017, 1, 11), y: 12.7 },
    { x: new Date(2017, 1, 18), y: 13.6 },
    { x: new Date(2017, 1, 25), y: 14.0 },
    { x: new Date(2017, 2, 4), y: 13.9 },
    { x: new Date(2017, 2, 11), y: 26.4 }
];
export const gravitySeries: IDataSeries = {
    type: linetype,
    name: "Gravity",
    color: "green",
    axisYIndex: 2,
    showInLegend: true,
    dataPoints: [
        { x: new Date(2017, 0, 7), y: 18.5 },
        { x: new Date(2017, 0, 14), y: 20.3 },
        { x: new Date(2017, 0, 21), y: 17.7 },
        { x: new Date(2017, 0, 28), y: 15.5 },
        { x: new Date(2017, 1, 4), y: 10.6 },
        { x: new Date(2017, 1, 11), y: 12.7 },
        { x: new Date(2017, 1, 18), y: 13.6 },
        { x: new Date(2017, 1, 25), y: 14.0 },
        { x: new Date(2017, 2, 4), y: 13.9 },
        { x: new Date(2017, 2, 11), y: 26.4 }
    ]
};

export const tempUnitSeries: IDataSeries = {
    type: linetype,
    name: "TempUnit",
    color: "#C24642",
    axisYIndex: 0,
    showInLegend: true,
    dataPoints: [
        { x: new Date(2017, 0, 7), y: 'C' },
        { x: new Date(2017, 0, 14), y: 'C' },
        { x: new Date(2017, 0, 21), y: 'C' },
        { x: new Date(2017, 0, 28), y: 'C' },
        { x: new Date(2017, 1, 4), y: 'C' },
        { x: new Date(2017, 1, 11), y: 'C' },
        { x: new Date(2017, 1, 18), y: 'C' },
        { x: new Date(2017, 1, 25), y: 'C' },
        { x: new Date(2017, 2, 4), y: 'C' },
        { x: new Date(2017, 2, 11), y: 'C' },
        { x: new Date(2017, 2, 18), y: 'C' },
        { x: new Date(2017, 2, 25), y: 'C' }
    ]

};

export const intervalSeries: IDataSeries = {
    type: linetype,
    name: "Interval",
    color: "#C24642",
    axisYIndex: 0,
    showInLegend: true,
    dataPoints: [
        { x: new Date(2017, 0, 7), y: 5 },
        { x: new Date(2017, 0, 14), y: 5 },
        { x: new Date(2017, 0, 21), y: 5 },
        { x: new Date(2017, 0, 28), y: 5 },
        { x: new Date(2017, 1, 4), y: 5 },
        { x: new Date(2017, 1, 11), y: 5 },
        { x: new Date(2017, 1, 18), y: 5 },
        { x: new Date(2017, 1, 25), y: 5 },
        { x: new Date(2017, 2, 4), y: 5 },
        { x: new Date(2017, 2, 11), y: 5 },
        { x: new Date(2017, 2, 18), y: 5 },
        { x: new Date(2017, 2, 25), y: 5 }
    ]
};

export const rssiSeries: IDataSeries = {
    type: linetype,
    name: "RSSI",
    color: "blue",
    axisYIndex: 1,
    axisYType: "secondary",
    showInLegend: true,
    dataPoints: [
        { x: new Date(2017, 0, 7), y: 42.5 },
        { x: new Date(2017, 0, 14), y: 44.3 },
        { x: new Date(2017, 0, 21), y: 28.7 },
        { x: new Date(2017, 0, 28), y: 22.5 },
        { x: new Date(2017, 1, 4), y: 25.6 },
        { x: new Date(2017, 1, 11), y: 45.7 },
        { x: new Date(2017, 1, 18), y: 54.6 },
        { x: new Date(2017, 1, 25), y: 32.0 },
        { x: new Date(2017, 2, 4), y: 43.9 },
        { x: new Date(2017, 2, 11), y: 26.4 },
        { x: new Date(2017, 2, 18), y: 40.3 },
        { x: new Date(2017, 2, 25), y: 54.2 }
    ]
};

export const testData: IDataSeries[] = [
    tempSeries,
    tiltSeries,
    batterySeries,
    gravitySeries,
    rssiSeries
];

export const testUnits: IDataSeries[] = [
    intervalSeries,
    tempUnitSeries,
];
