import { IAxisYDefinition } from 'src/classes/AxisDefinitions/IAxisYDefinition';

export const GravityDefinition: IAxisYDefinition = {
        title: "Gravity",
        lineColor: "green",
        tickColor: "green",
        labelFontColor: "green",
        titleFontColor: "green",
        suffix: "Plato"
};

export const TiltDefinition : IAxisYDefinition = {
        title: "Tilt",
        lineColor: "#C24642",
        tickColor: "#C24642",
        labelFontColor: "#C24642",
        titleFontColor: "#C24642",
        suffix: "degrees"
};

export const RssiDefinition : IAxisYDefinition = {
        title: "RSSI",
        lineColor: "blue",
        tickColor: "blue",
        labelFontColor: "blue",
        titleFontColor: "blue",
};
export const TemperatureDefinition : IAxisYDefinition = {
        title: "Temperature",
        lineColor: "#369EAD",
        tickColor: "#369EAD",
        labelFontColor: "#369EAD",
        titleFontColor: "#369EAD",
        suffix: "C"

};

export const BatteryDefinition : IAxisYDefinition = {
        title: "Battery",
        lineColor: "#7F6084",
        tickColor: "#7F6084",
        labelFontColor: "#7F6084",
        titleFontColor: "#7F6084",
        suffix: "%"

};