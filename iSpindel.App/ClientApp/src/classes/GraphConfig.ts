import { IDataSeries } from './Data/IDataSeries';
import { IAxisYDefinition } from './AxisDefinitions/IAxisYDefinition';

export class GraphConfig {

    zoomEnabled: boolean;
    animationEnabled: boolean;
    exportEnabled: boolean;
    title: { text: string };
    subtitles: [{ text: string }];
    axisY: IAxisYDefinition[];
    toolTip: { shared: boolean };
    legend: {
        cursor: string,
        itemclick: any
    };
    data: IDataSeries[];

    constructor(axisY: IAxisYDefinition[], data: IDataSeries[]) {
        this.zoomEnabled = true;
        this.animationEnabled = true;
        this.exportEnabled = true;
        this.title = { text: "iSpindel Beer Processing Overview" },
            this.subtitles = [{ text: "Watch the Beer get better!" }],
            this.axisY = axisY,
            this.toolTip = { shared: true },
            this.legend = {
                cursor: "pointer",
                itemclick: this.toggleCallback
            },
            this.data = data
    }

    public toggleCallback(chartContainer: any) {
        if (typeof (chartContainer.dataSeries.visible) === "undefined" || chartContainer.dataSeries.visible) {
            chartContainer.dataSeries.visible = false;
        } else {
            chartContainer.dataSeries.visible = true;
        }
        chartContainer.chart.render();
    }
}