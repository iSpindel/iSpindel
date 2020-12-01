/*
import * as d3 from 'd3';
import { Observable } from 'rxjs';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { ChartData } from './ChartData';

export class MultilineChart {

    private div: d3.Selection<SVGElement, {}, HTMLElement, any>;
    private margin: any = { top: 20, right: 20, bottom: 30, left: 30 };
    private data: ChartData;

    private x = d3.scaleUtc()
        .domain(d3.extent(data.dates))
        .range([this.margin.left, this.width - this.margin.right])

    private y = d3.scaleLinear()
        .domain([0, d3.max(data.series, d => d3.max(d.values))]).nice()
        .range([this.height - this.margin.bottom, this.margin.top])

    private xAxis = g => g
        .attr("transform", `translate(0,${this.height - this.margin.bottom})`)
        .call(d3.axisBottom(this.x).ticks(this.width / 80).tickSizeOuter(0))

    private yAxis = g => g
        .attr("transform", `translate(${this.margin.left},0)`)
        .call(d3.axisLeft(this.y))
        .call(g => g.select(".domain").remove())
        .call(g => g.select(".tick:last-of-type text").clone()
            .attr("x", 3)
            .attr("text-anchor", "start")
            .attr("font-weight", "bold"));

    private line = d3.line()
        .defined(d => !isNaN(d))
        .x((d, i) => this.x(this.data.dates[i]))
        .y(d => this.y(d))

    constructor(private dataObservable: IDataPoint[], private svgId: string,
        public width: number = 800,
        public height: number = 800) {

            this.data = ChartData.fromDataPoints(dataObservable);

        this.div = d3.select('svgId')
    }

    public initialize(): SVGSVGElement {

        let svg = this.div
            .append('svg')
            .attr('width', '100%')
            .attr('height', '100%')
            .attr('viewBox', -this.width / 2 + ' ' + -this.height / 2 + ' ' + this.width + ' ' + this.height)
            .style("overflow", "visible");

        svg.append("g")
            .call(this.xAxis);

        svg.append("g")
            .call(this.yAxis);

        const path = svg.append("g")
            .attr("fill", "none")
            .attr("stroke", "steelblue")
            .attr("stroke-width", 1.5)
            .attr("stroke-linejoin", "round")
            .attr("stroke-linecap", "round")
            .selectAll("path")
            .data(this.data)
            .join("path")
            .style("mix-blend-mode", "multiply")
            .attr("d", d => this.line(d.values));

        svg.call(this.hover, path);


        return svg.node();
        /*
         d3.timeFormat("%Y%m%d"); 
      var x = d3.time.scale()
        .range([0, width]);
  
      var y = d3.scale.linear()
        .range([height, 0]);
  
      var color = d3.scale.category10();
  
      var xAxis = d3.svg.axis()
        .scale(x)
        .orient("bottom");
  
      var yAxis = d3.svg.axis()
        .scale(y)
        .orient("left");
  
      var line = d3.svg.line()
        .interpolate("basis")
        .x(function(d) {
          return x(d.date);
        })
        .y(function(d) {
          return y(d.temperature);
        });
  
      var svg = d3.select("body").append("svg")
        .attr("width", width + margin.left + margin.right)
        .attr("height", height + margin.top + margin.bottom)
        .append("g")
        .attr("transform", "translate(" + margin.left + "," + margin.top + ")");
  
      var data = d3.tsv.parse(myData);
  
      color.domain(d3.keys(data[0]).filter(function(key) {
        return key !== "date";
      }));
  
      data.forEach(function(d) {
        d.date = parseDate(d.date);
      });
  
      var cities = color.domain().map(function(name) {
        return {
          name: name,
          values: data.map(function(d) {
            return {
              date: d.date,
              temperature: +d[name]
            };
          })
        };
      });
  
      x.domain(d3.extent(data, function(d) {
        return d.date;
      }));
  
      y.domain([
        d3.min(cities, function(c) {
          return d3.min(c.values, function(v) {
            return v.temperature;
          });
        }),
        d3.max(cities, function(c) {
          return d3.max(c.values, function(v) {
            return v.temperature;
          });
        })
      ]);
  
      var legend = svg.selectAll('g')
        .data(cities)
        .enter()
        .append('g')
        .attr('class', 'legend');
  
      legend.append('rect')
        .attr('x', width - 20)
        .attr('y', function(d, i) {
          return i * 20;
        })
        .attr('width', 10)
        .attr('height', 10)
        .style('fill', function(d) {
          return color(d.name);
        });
  
      legend.append('text')
        .attr('x', width - 8)
        .attr('y', function(d, i) {
          return (i * 20) + 9;
        })
        .text(function(d) {
          return d.name;
        });
  
      svg.append("g")
        .attr("class", "x axis")
        .attr("transform", "translate(0," + height + ")")
        .call(xAxis);
  
      svg.append("g")
        .attr("class", "y axis")
        .call(yAxis)
        .append("text")
        .attr("transform", "rotate(-90)")
        .attr("y", 6)
        .attr("dy", ".71em")
        .style("text-anchor", "end")
        .text("Temperature (ºF)");
  
      var city = svg.selectAll(".city")
        .data(cities)
        .enter().append("g")
        .attr("class", "city");
  
      city.append("path")
        .attr("class", "line")
        .attr("d", function(d) {
          return line(d.values);
        })
        .style("stroke", function(d) {
          return color(d.name);
        });
  
      city.append("text")
        .datum(function(d) {
          return {
            name: d.name,
            value: d.values[d.values.length - 1]
          };
        })
        .attr("transform", function(d) {
          return "translate(" + x(d.value.date) + "," + y(d.value.temperature) + ")";
        })
        .attr("x", 3)
        .attr("dy", ".35em")
        .text(function(d) {
          return d.name;
        });
  
      var mouseG = svg.append("g")
        .attr("class", "mouse-over-effects");
  
      mouseG.append("path") // this is the black vertical line to follow mouse
        .attr("class", "mouse-line")
        .style("stroke", "black")
        .style("stroke-width", "1px")
        .style("opacity", "0");
        
      var lines = document.getElementsByClassName('line');
  
      var mousePerLine = mouseG.selectAll('.mouse-per-line')
        .data(cities)
        .enter()
        .append("g")
        .attr("class", "mouse-per-line");
  
      mousePerLine.append("circle")
        .attr("r", 7)
        .style("stroke", function(d) {
          return color(d.name);
        })
        .style("fill", "none")
        .style("stroke-width", "1px")
        .style("opacity", "0");
  
      mousePerLine.append("text")
        .attr("transform", "translate(10,3)");
  
      mouseG.append('svg:rect') // append a rect to catch mouse movements on canvas
        .attr('width', width) // can't catch mouse events on a g element
        .attr('height', height)
        .attr('fill', 'none')
        .attr('pointer-events', 'all')
        .on('mouseout', function() { // on mouse out hide line, circles and text
          d3.select(".mouse-line")
            .style("opacity", "0");
          d3.selectAll(".mouse-per-line circle")
            .style("opacity", "0");
          d3.selectAll(".mouse-per-line text")
            .style("opacity", "0");
        })
        .on('mouseover', function() { // on mouse in show line, circles and text
          d3.select(".mouse-line")
            .style("opacity", "1");
          d3.selectAll(".mouse-per-line circle")
            .style("opacity", "1");
          d3.selectAll(".mouse-per-line text")
            .style("opacity", "1");
        })
        .on('mousemove', function() { // mouse moving over canvas
          var mouse = d3.mouse(this);
          d3.select(".mouse-line")
            .attr("d", function() {
              var d = "M" + mouse[0] + "," + height;
              d += " " + mouse[0] + "," + 0;
              return d;
            });
  
          d3.selectAll(".mouse-per-line")
            .attr("transform", function(d, i) {
              console.log(width/mouse[0])
              var xDate = x.invert(mouse[0]),
                  bisect = d3.bisector(function(d) { return d.date; }).right;
                  idx = bisect(d.values, xDate);
              
              var beginning = 0,
                  end = lines[i].getTotalLength(),
                  target = null;
  
              while (true){
                target = Math.floor((beginning + end) / 2);
                pos = lines[i].getPointAtLength(target);
                if ((target === end || target === beginning) && pos.x !== mouse[0]) {
                    break;
                }
                if (pos.x > mouse[0])      end = target;
                else if (pos.x < mouse[0]) beginning = target;
                else break; //position found
              }
              
              d3.select(this).select('text')
                .text(y.invert(pos.y).toFixed(2));
                
              return "translate(" + mouse[0] + "," + pos.y +")";
            });
        });
    }

    private hover(svg, path) {
  
  if ("ontouchstart" in document) svg
      .style("-webkit-tap-highlight-color", "transparent")
      .on("touchmove", this.moved)
      .on("touchstart", entered)
      .on("touchend", left)
  else svg
      .on("mousemove", moved)
      .on("mouseenter", entered)
      .on("mouseleave", left);

  const dot = svg.append("g")
      .attr("display", "none");

  dot.append("circle")
      .attr("r", 2.5);

  dot.append("text")
      .attr("font-family", "sans-serif")
      .attr("font-size", 10)
      .attr("text-anchor", "middle")
      .attr("y", -8);

  function moved(event) {
    event.preventDefault();
    const pointer = d3.pointer(event, this);
    const xm = this.x.invert(pointer[0]);
    const ym = this.y.invert(pointer[1]);
    const i = d3.bisectCenter(this.data.dates, xm);
    const s = d3.least(this.data.series, d => Math.abs(d.values[i] - ym));
    path.attr("stroke", d => d === s ? null : "#ddd").filter(d => d === s).raise();
    dot.attr("transform", `translate(${this.x(this.data.dates[i])},${y(s.values[i])})`);
    dot.select("text").text(s.name);
  }

  function entered() {
    path.style("mix-blend-mode", null).attr("stroke", "#ddd");
    dot.attr("display", null);
  }

  function left() {
    path.style("mix-blend-mode", "multiply").attr("stroke", null);
    dot.attr("display", "none");
  }
}
}
*/