﻿using System;

namespace Core.danmaku2ass
{
    public class Config
    {
        public string Title = "Downkyi";
        public int ScreenWidth = 1920;
        public int ScreenHeight = 1080;
        public string FontName = "黑体";
        public int BaseFontSize; // 字体大小，像素
        // 限制行数
        private int lineCount;
        public int LineCount
        {
            get { return lineCount; }
            set
            {
                if (value == 0)
                {
                    lineCount = (int)Math.Floor(ScreenHeight / BaseFontSize * 1.0);
                }
                else
                {
                    lineCount = value;
                }
            }
        }
        public string LayoutAlgorithm; // 布局算法，async/sync
        public int TuneDuration; // 微调时长
        public int DropOffset; // 丢弃偏移
        public int BottomMargin; // 底部边距
        public int CustomOffset; // 自定义偏移
        public string HeaderTemplate = @"[Script Info]
; Script generated by Downkyi Danmaku Converter
; https://github.com/FlySelfLog/downkyi
Title: {title}
ScriptType: v4.00+
Collisions: Normal
PlayResX: {width}
PlayResY: {height}
Timer: 10.0000
WrapStyle: 2
ScaledBorderAndShadow: no

[V4+ Styles]
Format: Name, Fontname, Fontsize, PrimaryColour, SecondaryColour, OutlineColour, BackColour, Bold, Italic, Underline, StrikeOut, ScaleX, ScaleY, Spacing, Angle, BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, Encoding
Style: Default,{fontname},54,&H00FFFFFF,&H00FFFFFF,&H00000000,&H00000000,0,0,0,0,100,100,0.00,0.00,1,2.00,0.00,2,30,30,120,0
Style: Alternate,{fontname},36,&H00FFFFFF,&H00FFFFFF,&H00000000,&H00000000,0,0,0,0,100,100,0.00,0.00,1,2.00,0.00,2,30,30,84,0
Style: Danmaku,{fontname},{fontsize},&H00FFFFFF,&H00FFFFFF,&H00000000,&H00000000,0,0,0,0,100,100,0.00,0.00,1,1.00,0.00,2,30,30,30,0

[Events]
Format: Layer, Start, End, Style, Name, MarginL, MarginR, MarginV, Effect, Text";
    }
}
