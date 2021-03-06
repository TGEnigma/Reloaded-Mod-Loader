﻿/*
    [Reloaded] Mod Loader Launcher
    The launcher for a universal, powerful, multi-game and multi-process mod loader
    based off of the concept of DLL Injection to execute arbitrary program code.
    Copyright (C) 2018  Sewer. Sz (Sewer56)

    [Reloaded] is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    [Reloaded] is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>
*/

using Reloaded_GUI.Styles.Controls.Animated;
using Reloaded_GUI.Styles.Controls.Enhanced;

namespace ReloadedLauncher.Windows.Children
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Reloaded_GUI.Styles.Animation.AnimProperties animProperties1 = new Reloaded_GUI.Styles.Animation.AnimProperties();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage1 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage2 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimProperties animProperties2 = new Reloaded_GUI.Styles.Animation.AnimProperties();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage3 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage4 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimProperties animProperties3 = new Reloaded_GUI.Styles.Animation.AnimProperties();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage5 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage6 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimProperties animProperties4 = new Reloaded_GUI.Styles.Animation.AnimProperties();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage7 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage8 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimProperties animProperties5 = new Reloaded_GUI.Styles.Animation.AnimProperties();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage9 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage10 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimProperties animProperties6 = new Reloaded_GUI.Styles.Animation.AnimProperties();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage11 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage12 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Reloaded_GUI.Styles.Animation.AnimProperties animProperties7 = new Reloaded_GUI.Styles.Animation.AnimProperties();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage13 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage14 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimProperties animProperties8 = new Reloaded_GUI.Styles.Animation.AnimProperties();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage15 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage16 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimProperties animProperties9 = new Reloaded_GUI.Styles.Animation.AnimProperties();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage17 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            Reloaded_GUI.Styles.Animation.AnimMessage animMessage18 = new Reloaded_GUI.Styles.Animation.AnimMessage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.item_GameBanner = new System.Windows.Forms.PictureBox();
            this.tooltipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.item_LaunchBox = new Reloaded_GUI.Styles.Controls.Animated.AnimatedButton();
            this.item_QuitBox = new Reloaded_GUI.Styles.Controls.Animated.AnimatedButton();
            this.item_InjectionBoxInjection = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.box_InjectionBox = new Reloaded_GUI.Styles.Controls.Animated.AnimatedButton();
            this.item_VersionBoxVersion = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.box_VersionBox = new Reloaded_GUI.Styles.Controls.Animated.AnimatedButton();
            this.box_PictureBox = new Reloaded_GUI.Styles.Controls.Animated.AnimatedButton();
            this.box_GameList = new Reloaded_GUI.Styles.Controls.Animated.AnimatedDataGridView();
            this.modName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box_GameListBox = new Reloaded_GUI.Styles.Controls.Animated.AnimatedButton();
            this.item_NoteBoxVerPath = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.item_NoteBoxEXEPath = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.item_NoteBoxVERTitle = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.item_NoteBoxEXETitle = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.item_NoteBoxGameName = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.item_NoteBoxSeparator = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.box_NoteBox = new Reloaded_GUI.Styles.Controls.Animated.AnimatedButton();
            this.item_LocationBoxEXEPath = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.item_LocationBoxDirectoryPath = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.item_LocationBoxDirectoryTitle = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.item_LocationBoxEXETitle = new Reloaded_GUI.Styles.Controls.Enhanced.EnhancedLabel();
            this.box_LocationBox = new Reloaded_GUI.Styles.Controls.Animated.AnimatedButton();
            ((System.ComponentModel.ISupportInitialize)(this.item_GameBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_GameList)).BeginInit();
            this.SuspendLayout();
            // 
            // item_GameBanner
            // 
            this.item_GameBanner.Location = new System.Drawing.Point(590, 40);
            this.item_GameBanner.Name = "item_GameBanner";
            this.item_GameBanner.Size = new System.Drawing.Size(271, 83);
            this.item_GameBanner.TabIndex = 15;
            this.item_GameBanner.TabStop = false;
            // 
            // item_LaunchBox
            // 
            animMessage1.Control = this.item_LaunchBox;
            animMessage1.PlayAnimation = true;
            animProperties1.BackColorMessage = animMessage1;
            animMessage2.Control = this.item_LaunchBox;
            animMessage2.PlayAnimation = true;
            animProperties1.ForeColorMessage = animMessage2;
            animProperties1.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties1.MouseEnterDuration = 0F;
            animProperties1.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties1.MouseEnterFramerate = 0F;
            animProperties1.MouseEnterOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties1.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties1.MouseLeaveDuration = 0F;
            animProperties1.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties1.MouseLeaveFramerate = 0F;
            animProperties1.MouseLeaveOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.item_LaunchBox.AnimProperties = animProperties1;
            this.item_LaunchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.item_LaunchBox.CaptureChildren = true;
            this.item_LaunchBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.item_LaunchBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.item_LaunchBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.item_LaunchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_LaunchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_LaunchBox.ForeColor = System.Drawing.Color.White;
            this.item_LaunchBox.IgnoreMouse = false;
            this.item_LaunchBox.IgnoreMouseClicks = false;
            this.item_LaunchBox.Location = new System.Drawing.Point(690, 429);
            this.item_LaunchBox.Name = "item_LaunchBox";
            this.item_LaunchBox.Size = new System.Drawing.Size(172, 43);
            this.item_LaunchBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_LaunchBox.TabIndex = 22;
            this.item_LaunchBox.Text = "Launch";
            this.item_LaunchBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.tooltipHelper.SetToolTip(this.item_LaunchBox, "Left click to launch game.\r\nHold CTRL/Control for advanced options.");
            this.item_LaunchBox.UseVisualStyleBackColor = false;
            this.item_LaunchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.item_LaunchBox_MouseClick);
            // 
            // item_QuitBox
            // 
            animMessage3.Control = this.item_QuitBox;
            animMessage3.PlayAnimation = true;
            animProperties2.BackColorMessage = animMessage3;
            animMessage4.Control = this.item_QuitBox;
            animMessage4.PlayAnimation = true;
            animProperties2.ForeColorMessage = animMessage4;
            animProperties2.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties2.MouseEnterDuration = 0F;
            animProperties2.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties2.MouseEnterFramerate = 0F;
            animProperties2.MouseEnterOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties2.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties2.MouseLeaveDuration = 0F;
            animProperties2.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties2.MouseLeaveFramerate = 0F;
            animProperties2.MouseLeaveOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.item_QuitBox.AnimProperties = animProperties2;
            this.item_QuitBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.item_QuitBox.CaptureChildren = true;
            this.item_QuitBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.item_QuitBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.item_QuitBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.item_QuitBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_QuitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_QuitBox.ForeColor = System.Drawing.Color.White;
            this.item_QuitBox.IgnoreMouse = false;
            this.item_QuitBox.IgnoreMouseClicks = false;
            this.item_QuitBox.Location = new System.Drawing.Point(504, 429);
            this.item_QuitBox.Name = "item_QuitBox";
            this.item_QuitBox.Size = new System.Drawing.Size(156, 43);
            this.item_QuitBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_QuitBox.TabIndex = 21;
            this.item_QuitBox.Text = "Quit";
            this.item_QuitBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.item_QuitBox.UseVisualStyleBackColor = false;
            this.item_QuitBox.Click += new System.EventHandler(this.QuitBox_Click);
            // 
            // item_InjectionBoxInjection
            // 
            this.item_InjectionBoxInjection.BackColor = System.Drawing.Color.Transparent;
            this.item_InjectionBoxInjection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_InjectionBoxInjection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.item_InjectionBoxInjection.ForeColor = System.Drawing.Color.White;
            this.item_InjectionBoxInjection.IgnoreMouse = false;
            this.item_InjectionBoxInjection.Location = new System.Drawing.Point(244, 438);
            this.item_InjectionBoxInjection.Margin = new System.Windows.Forms.Padding(0);
            this.item_InjectionBoxInjection.Name = "item_InjectionBoxInjection";
            this.item_InjectionBoxInjection.Size = new System.Drawing.Size(228, 24);
            this.item_InjectionBoxInjection.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_InjectionBoxInjection.TabIndex = 20;
            this.item_InjectionBoxInjection.Text = "Injection: Instant";
            this.item_InjectionBoxInjection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.item_InjectionBoxInjection.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // box_InjectionBox
            // 
            animMessage5.Control = this.box_InjectionBox;
            animMessage5.PlayAnimation = true;
            animProperties3.BackColorMessage = animMessage5;
            animMessage6.Control = this.box_InjectionBox;
            animMessage6.PlayAnimation = true;
            animProperties3.ForeColorMessage = animMessage6;
            animProperties3.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties3.MouseEnterDuration = 0F;
            animProperties3.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties3.MouseEnterFramerate = 0F;
            animProperties3.MouseEnterOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties3.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties3.MouseLeaveDuration = 0F;
            animProperties3.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties3.MouseLeaveFramerate = 0F;
            animProperties3.MouseLeaveOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_InjectionBox.AnimProperties = animProperties3;
            this.box_InjectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_InjectionBox.CaptureChildren = true;
            this.box_InjectionBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.box_InjectionBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_InjectionBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_InjectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_InjectionBox.IgnoreMouse = false;
            this.box_InjectionBox.IgnoreMouseClicks = true;
            this.box_InjectionBox.Location = new System.Drawing.Point(242, 429);
            this.box_InjectionBox.Name = "box_InjectionBox";
            this.box_InjectionBox.Size = new System.Drawing.Size(232, 43);
            this.box_InjectionBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.box_InjectionBox.TabIndex = 19;
            this.box_InjectionBox.Text = null;
            this.box_InjectionBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.box_InjectionBox.UseVisualStyleBackColor = false;
            // 
            // item_VersionBoxVersion
            // 
            this.item_VersionBoxVersion.BackColor = System.Drawing.Color.Transparent;
            this.item_VersionBoxVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_VersionBoxVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.item_VersionBoxVersion.ForeColor = System.Drawing.Color.White;
            this.item_VersionBoxVersion.IgnoreMouse = false;
            this.item_VersionBoxVersion.Location = new System.Drawing.Point(42, 438);
            this.item_VersionBoxVersion.Margin = new System.Windows.Forms.Padding(0);
            this.item_VersionBoxVersion.Name = "item_VersionBoxVersion";
            this.item_VersionBoxVersion.Size = new System.Drawing.Size(168, 24);
            this.item_VersionBoxVersion.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_VersionBoxVersion.TabIndex = 18;
            this.item_VersionBoxVersion.Text = "Version: 0.85";
            this.item_VersionBoxVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.item_VersionBoxVersion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // box_VersionBox
            // 
            animMessage7.Control = this.box_VersionBox;
            animMessage7.PlayAnimation = true;
            animProperties4.BackColorMessage = animMessage7;
            animMessage8.Control = this.box_VersionBox;
            animMessage8.PlayAnimation = true;
            animProperties4.ForeColorMessage = animMessage8;
            animProperties4.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties4.MouseEnterDuration = 0F;
            animProperties4.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties4.MouseEnterFramerate = 0F;
            animProperties4.MouseEnterOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties4.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties4.MouseLeaveDuration = 0F;
            animProperties4.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties4.MouseLeaveFramerate = 0F;
            animProperties4.MouseLeaveOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_VersionBox.AnimProperties = animProperties4;
            this.box_VersionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_VersionBox.CaptureChildren = true;
            this.box_VersionBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.box_VersionBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_VersionBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_VersionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_VersionBox.IgnoreMouse = false;
            this.box_VersionBox.IgnoreMouseClicks = true;
            this.box_VersionBox.Location = new System.Drawing.Point(40, 429);
            this.box_VersionBox.Name = "box_VersionBox";
            this.box_VersionBox.Size = new System.Drawing.Size(172, 43);
            this.box_VersionBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.box_VersionBox.TabIndex = 17;
            this.box_VersionBox.Text = null;
            this.box_VersionBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.box_VersionBox.UseVisualStyleBackColor = false;
            // 
            // box_PictureBox
            // 
            animMessage9.Control = this.box_PictureBox;
            animMessage9.PlayAnimation = true;
            animProperties5.BackColorMessage = animMessage9;
            animMessage10.Control = this.box_PictureBox;
            animMessage10.PlayAnimation = true;
            animProperties5.ForeColorMessage = animMessage10;
            animProperties5.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties5.MouseEnterDuration = 0F;
            animProperties5.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties5.MouseEnterFramerate = 0F;
            animProperties5.MouseEnterOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties5.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties5.MouseLeaveDuration = 0F;
            animProperties5.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties5.MouseLeaveFramerate = 0F;
            animProperties5.MouseLeaveOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_PictureBox.AnimProperties = animProperties5;
            this.box_PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_PictureBox.CaptureChildren = true;
            this.box_PictureBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.box_PictureBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_PictureBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_PictureBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_PictureBox.IgnoreMouse = true;
            this.box_PictureBox.IgnoreMouseClicks = true;
            this.box_PictureBox.Location = new System.Drawing.Point(589, 39);
            this.box_PictureBox.Name = "box_PictureBox";
            this.box_PictureBox.Size = new System.Drawing.Size(273, 85);
            this.box_PictureBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.box_PictureBox.TabIndex = 16;
            this.box_PictureBox.Text = null;
            this.box_PictureBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.box_PictureBox.UseVisualStyleBackColor = false;
            // 
            // box_GameList
            // 
            this.box_GameList.AllowUserToAddRows = false;
            this.box_GameList.AllowUserToDeleteRows = false;
            this.box_GameList.AllowUserToResizeColumns = false;
            this.box_GameList.AllowUserToResizeRows = false;
            animMessage11.Control = this.box_GameList;
            animMessage11.PlayAnimation = true;
            animProperties6.BackColorMessage = animMessage11;
            animMessage12.Control = this.box_GameList;
            animMessage12.PlayAnimation = true;
            animProperties6.ForeColorMessage = animMessage12;
            animProperties6.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties6.MouseEnterDuration = 0F;
            animProperties6.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties6.MouseEnterFramerate = 0F;
            animProperties6.MouseEnterOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties6.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties6.MouseLeaveDuration = 0F;
            animProperties6.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties6.MouseLeaveFramerate = 0F;
            animProperties6.MouseLeaveOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_GameList.AnimProperties = animProperties6;
            this.box_GameList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.box_GameList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_GameList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.box_GameList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.box_GameList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.box_GameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.box_GameList.ColumnHeadersVisible = false;
            this.box_GameList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modName,
            this.modDirectory});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.box_GameList.DefaultCellStyle = dataGridViewCellStyle3;
            this.box_GameList.DragRowIndex = 0;
            this.box_GameList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.box_GameList.EnableHeadersVisualStyles = false;
            this.box_GameList.GridColor = System.Drawing.Color.White;
            this.box_GameList.Location = new System.Drawing.Point(41, 40);
            this.box_GameList.MultiSelect = false;
            this.box_GameList.Name = "box_GameList";
            this.box_GameList.ReadOnly = true;
            this.box_GameList.ReorderingEnabled = false;
            this.box_GameList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.box_GameList.RowHeadersVisible = false;
            this.box_GameList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.box_GameList.RowTemplate.Height = 30;
            this.box_GameList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.box_GameList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.box_GameList.ShowCellToolTips = false;
            this.box_GameList.Size = new System.Drawing.Size(518, 251);
            this.box_GameList.StandardTab = true;
            this.box_GameList.TabIndex = 14;
            this.box_GameList.SelectionChanged += new System.EventHandler(this.GameList_SelectionChanged);
            // 
            // modName
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.modName.DefaultCellStyle = dataGridViewCellStyle1;
            this.modName.FillWeight = 152.2843F;
            this.modName.HeaderText = "Mod name";
            this.modName.Name = "modName";
            this.modName.ReadOnly = true;
            this.modName.Width = 200;
            // 
            // modDirectory
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.modDirectory.DefaultCellStyle = dataGridViewCellStyle2;
            this.modDirectory.FillWeight = 47.71573F;
            this.modDirectory.HeaderText = "Mod Directory";
            this.modDirectory.Name = "modDirectory";
            this.modDirectory.ReadOnly = true;
            this.modDirectory.Width = 318;
            // 
            // box_GameListBox
            // 
            animMessage13.Control = this.box_GameListBox;
            animMessage13.PlayAnimation = true;
            animProperties7.BackColorMessage = animMessage13;
            animMessage14.Control = this.box_GameListBox;
            animMessage14.PlayAnimation = true;
            animProperties7.ForeColorMessage = animMessage14;
            animProperties7.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties7.MouseEnterDuration = 0F;
            animProperties7.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties7.MouseEnterFramerate = 0F;
            animProperties7.MouseEnterOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties7.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties7.MouseLeaveDuration = 0F;
            animProperties7.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties7.MouseLeaveFramerate = 0F;
            animProperties7.MouseLeaveOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_GameListBox.AnimProperties = animProperties7;
            this.box_GameListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_GameListBox.CaptureChildren = false;
            this.box_GameListBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.box_GameListBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_GameListBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_GameListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_GameListBox.IgnoreMouse = true;
            this.box_GameListBox.IgnoreMouseClicks = true;
            this.box_GameListBox.Location = new System.Drawing.Point(40, 39);
            this.box_GameListBox.Margin = new System.Windows.Forms.Padding(0);
            this.box_GameListBox.Name = "box_GameListBox";
            this.box_GameListBox.Size = new System.Drawing.Size(520, 253);
            this.box_GameListBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.box_GameListBox.TabIndex = 13;
            this.box_GameListBox.Text = null;
            this.box_GameListBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.box_GameListBox.UseVisualStyleBackColor = false;
            // 
            // item_NoteBoxVerPath
            // 
            this.item_NoteBoxVerPath.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxVerPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxVerPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxVerPath.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxVerPath.IgnoreMouse = false;
            this.item_NoteBoxVerPath.Location = new System.Drawing.Point(653, 257);
            this.item_NoteBoxVerPath.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxVerPath.Name = "item_NoteBoxVerPath";
            this.item_NoteBoxVerPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxVerPath.Size = new System.Drawing.Size(200, 24);
            this.item_NoteBoxVerPath.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxVerPath.TabIndex = 11;
            this.item_NoteBoxVerPath.Text = "Retail[US]";
            this.item_NoteBoxVerPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.item_NoteBoxVerPath.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxEXEPath
            // 
            this.item_NoteBoxEXEPath.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxEXEPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxEXEPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxEXEPath.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxEXEPath.IgnoreMouse = false;
            this.item_NoteBoxEXEPath.Location = new System.Drawing.Point(653, 222);
            this.item_NoteBoxEXEPath.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxEXEPath.Name = "item_NoteBoxEXEPath";
            this.item_NoteBoxEXEPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxEXEPath.Size = new System.Drawing.Size(200, 24);
            this.item_NoteBoxEXEPath.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxEXEPath.TabIndex = 10;
            this.item_NoteBoxEXEPath.Text = "NoRestrict";
            this.item_NoteBoxEXEPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.item_NoteBoxEXEPath.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxVERTitle
            // 
            this.item_NoteBoxVERTitle.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxVERTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxVERTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxVERTitle.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxVERTitle.IgnoreMouse = false;
            this.item_NoteBoxVERTitle.Location = new System.Drawing.Point(604, 257);
            this.item_NoteBoxVERTitle.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxVERTitle.Name = "item_NoteBoxVERTitle";
            this.item_NoteBoxVERTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxVERTitle.Size = new System.Drawing.Size(57, 24);
            this.item_NoteBoxVERTitle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxVERTitle.TabIndex = 9;
            this.item_NoteBoxVERTitle.Text = "VER:";
            this.item_NoteBoxVERTitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxEXETitle
            // 
            this.item_NoteBoxEXETitle.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxEXETitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxEXETitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxEXETitle.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxEXETitle.IgnoreMouse = false;
            this.item_NoteBoxEXETitle.Location = new System.Drawing.Point(604, 222);
            this.item_NoteBoxEXETitle.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxEXETitle.Name = "item_NoteBoxEXETitle";
            this.item_NoteBoxEXETitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxEXETitle.Size = new System.Drawing.Size(57, 24);
            this.item_NoteBoxEXETitle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxEXETitle.TabIndex = 8;
            this.item_NoteBoxEXETitle.Text = "EXE:";
            this.item_NoteBoxEXETitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxGameName
            // 
            this.item_NoteBoxGameName.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxGameName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxGameName.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxGameName.IgnoreMouse = false;
            this.item_NoteBoxGameName.Location = new System.Drawing.Point(592, 164);
            this.item_NoteBoxGameName.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxGameName.Name = "item_NoteBoxGameName";
            this.item_NoteBoxGameName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxGameName.Size = new System.Drawing.Size(269, 24);
            this.item_NoteBoxGameName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxGameName.TabIndex = 7;
            this.item_NoteBoxGameName.Text = "Sample Game";
            this.item_NoteBoxGameName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.item_NoteBoxGameName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxSeparator
            // 
            this.item_NoteBoxSeparator.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxSeparator.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxSeparator.IgnoreMouse = false;
            this.item_NoteBoxSeparator.Location = new System.Drawing.Point(592, 185);
            this.item_NoteBoxSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxSeparator.Name = "item_NoteBoxSeparator";
            this.item_NoteBoxSeparator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxSeparator.Size = new System.Drawing.Size(269, 24);
            this.item_NoteBoxSeparator.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxSeparator.TabIndex = 6;
            this.item_NoteBoxSeparator.Text = "_____________________";
            this.item_NoteBoxSeparator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.item_NoteBoxSeparator.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // box_NoteBox
            // 
            animMessage15.Control = this.box_NoteBox;
            animMessage15.PlayAnimation = true;
            animProperties8.BackColorMessage = animMessage15;
            animMessage16.Control = this.box_NoteBox;
            animMessage16.PlayAnimation = true;
            animProperties8.ForeColorMessage = animMessage16;
            animProperties8.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties8.MouseEnterDuration = 0F;
            animProperties8.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties8.MouseEnterFramerate = 0F;
            animProperties8.MouseEnterOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties8.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties8.MouseLeaveDuration = 0F;
            animProperties8.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties8.MouseLeaveFramerate = 0F;
            animProperties8.MouseLeaveOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_NoteBox.AnimProperties = animProperties8;
            this.box_NoteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_NoteBox.CaptureChildren = true;
            this.box_NoteBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.box_NoteBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_NoteBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_NoteBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_NoteBox.IgnoreMouse = false;
            this.box_NoteBox.IgnoreMouseClicks = true;
            this.box_NoteBox.Location = new System.Drawing.Point(589, 154);
            this.box_NoteBox.Name = "box_NoteBox";
            this.box_NoteBox.Size = new System.Drawing.Size(273, 138);
            this.box_NoteBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.box_NoteBox.TabIndex = 5;
            this.box_NoteBox.Text = null;
            this.box_NoteBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.box_NoteBox.UseVisualStyleBackColor = false;
            // 
            // item_LocationBoxEXEPath
            // 
            this.item_LocationBoxEXEPath.BackColor = System.Drawing.Color.Transparent;
            this.item_LocationBoxEXEPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_LocationBoxEXEPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_LocationBoxEXEPath.ForeColor = System.Drawing.Color.White;
            this.item_LocationBoxEXEPath.IgnoreMouse = false;
            this.item_LocationBoxEXEPath.Location = new System.Drawing.Point(172, 365);
            this.item_LocationBoxEXEPath.Margin = new System.Windows.Forms.Padding(0);
            this.item_LocationBoxEXEPath.Name = "item_LocationBoxEXEPath";
            this.item_LocationBoxEXEPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_LocationBoxEXEPath.Size = new System.Drawing.Size(680, 24);
            this.item_LocationBoxEXEPath.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_LocationBoxEXEPath.TabIndex = 4;
            this.item_LocationBoxEXEPath.Text = "$DIRECTORY + Duvalie.exe";
            this.item_LocationBoxEXEPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.item_LocationBoxEXEPath.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_LocationBoxDirectoryPath
            // 
            this.item_LocationBoxDirectoryPath.BackColor = System.Drawing.Color.Transparent;
            this.item_LocationBoxDirectoryPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_LocationBoxDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_LocationBoxDirectoryPath.ForeColor = System.Drawing.Color.White;
            this.item_LocationBoxDirectoryPath.IgnoreMouse = false;
            this.item_LocationBoxDirectoryPath.Location = new System.Drawing.Point(172, 331);
            this.item_LocationBoxDirectoryPath.Margin = new System.Windows.Forms.Padding(0);
            this.item_LocationBoxDirectoryPath.Name = "item_LocationBoxDirectoryPath";
            this.item_LocationBoxDirectoryPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_LocationBoxDirectoryPath.Size = new System.Drawing.Size(680, 24);
            this.item_LocationBoxDirectoryPath.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_LocationBoxDirectoryPath.TabIndex = 3;
            this.item_LocationBoxDirectoryPath.Text = "C:\\Program Files (x86)\\Arianrhod";
            this.item_LocationBoxDirectoryPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.item_LocationBoxDirectoryPath.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_LocationBoxDirectoryTitle
            // 
            this.item_LocationBoxDirectoryTitle.AutoSize = true;
            this.item_LocationBoxDirectoryTitle.BackColor = System.Drawing.Color.Transparent;
            this.item_LocationBoxDirectoryTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_LocationBoxDirectoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.item_LocationBoxDirectoryTitle.ForeColor = System.Drawing.Color.White;
            this.item_LocationBoxDirectoryTitle.IgnoreMouse = false;
            this.item_LocationBoxDirectoryTitle.Location = new System.Drawing.Point(52, 331);
            this.item_LocationBoxDirectoryTitle.Margin = new System.Windows.Forms.Padding(0);
            this.item_LocationBoxDirectoryTitle.Name = "item_LocationBoxDirectoryTitle";
            this.item_LocationBoxDirectoryTitle.Size = new System.Drawing.Size(131, 22);
            this.item_LocationBoxDirectoryTitle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_LocationBoxDirectoryTitle.TabIndex = 1;
            this.item_LocationBoxDirectoryTitle.Text = "DIRECTORY:";
            this.item_LocationBoxDirectoryTitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_LocationBoxEXETitle
            // 
            this.item_LocationBoxEXETitle.AutoSize = true;
            this.item_LocationBoxEXETitle.BackColor = System.Drawing.Color.Transparent;
            this.item_LocationBoxEXETitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_LocationBoxEXETitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_LocationBoxEXETitle.ForeColor = System.Drawing.Color.White;
            this.item_LocationBoxEXETitle.IgnoreMouse = false;
            this.item_LocationBoxEXETitle.Location = new System.Drawing.Point(52, 365);
            this.item_LocationBoxEXETitle.Name = "item_LocationBoxEXETitle";
            this.item_LocationBoxEXETitle.Size = new System.Drawing.Size(114, 22);
            this.item_LocationBoxEXETitle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_LocationBoxEXETitle.TabIndex = 2;
            this.item_LocationBoxEXETitle.Text = "EXE PATH:";
            this.item_LocationBoxEXETitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // box_LocationBox
            // 
            animMessage17.Control = this.box_LocationBox;
            animMessage17.PlayAnimation = true;
            animProperties9.BackColorMessage = animMessage17;
            animMessage18.Control = this.box_LocationBox;
            animMessage18.PlayAnimation = true;
            animProperties9.ForeColorMessage = animMessage18;
            animProperties9.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties9.MouseEnterDuration = 0F;
            animProperties9.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties9.MouseEnterFramerate = 0F;
            animProperties9.MouseEnterOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties9.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties9.MouseLeaveDuration = 0F;
            animProperties9.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties9.MouseLeaveFramerate = 0F;
            animProperties9.MouseLeaveOverride = Reloaded_GUI.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_LocationBox.AnimProperties = animProperties9;
            this.box_LocationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_LocationBox.CaptureChildren = true;
            this.box_LocationBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.box_LocationBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_LocationBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_LocationBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_LocationBox.IgnoreMouse = false;
            this.box_LocationBox.IgnoreMouseClicks = true;
            this.box_LocationBox.Location = new System.Drawing.Point(40, 322);
            this.box_LocationBox.Name = "box_LocationBox";
            this.box_LocationBox.Size = new System.Drawing.Size(822, 77);
            this.box_LocationBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.box_LocationBox.TabIndex = 0;
            this.box_LocationBox.Text = null;
            this.box_LocationBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.box_LocationBox.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(900, 512);
            this.Controls.Add(this.item_LaunchBox);
            this.Controls.Add(this.item_QuitBox);
            this.Controls.Add(this.item_InjectionBoxInjection);
            this.Controls.Add(this.box_InjectionBox);
            this.Controls.Add(this.item_VersionBoxVersion);
            this.Controls.Add(this.box_VersionBox);
            this.Controls.Add(this.item_GameBanner);
            this.Controls.Add(this.box_PictureBox);
            this.Controls.Add(this.box_GameList);
            this.Controls.Add(this.box_GameListBox);
            this.Controls.Add(this.item_NoteBoxVerPath);
            this.Controls.Add(this.item_NoteBoxEXEPath);
            this.Controls.Add(this.item_NoteBoxVERTitle);
            this.Controls.Add(this.item_NoteBoxEXETitle);
            this.Controls.Add(this.item_NoteBoxGameName);
            this.Controls.Add(this.item_NoteBoxSeparator);
            this.Controls.Add(this.box_NoteBox);
            this.Controls.Add(this.item_LocationBoxEXEPath);
            this.Controls.Add(this.item_LocationBoxDirectoryPath);
            this.Controls.Add(this.item_LocationBoxDirectoryTitle);
            this.Controls.Add(this.item_LocationBoxEXETitle);
            this.Controls.Add(this.box_LocationBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "Main_Screen";
            this.VisibleChanged += new System.EventHandler(this.Main_Screen_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.item_GameBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_GameList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Reloaded_GUI.Styles.Controls.Animated.AnimatedButton box_LocationBox;
        private EnhancedLabel item_LocationBoxDirectoryTitle;
        private EnhancedLabel item_LocationBoxEXETitle;
        private EnhancedLabel item_LocationBoxDirectoryPath;
        private EnhancedLabel item_LocationBoxEXEPath;
        private Reloaded_GUI.Styles.Controls.Animated.AnimatedButton box_NoteBox;
        private EnhancedLabel item_NoteBoxSeparator;
        private EnhancedLabel item_NoteBoxGameName;
        private EnhancedLabel item_NoteBoxEXETitle;
        private EnhancedLabel item_NoteBoxVERTitle;
        private EnhancedLabel item_NoteBoxEXEPath;
        private EnhancedLabel item_NoteBoxVerPath;
        private Reloaded_GUI.Styles.Controls.Animated.AnimatedButton box_GameListBox;
        private AnimatedDataGridView box_GameList;
        private AnimatedButton box_PictureBox;
        private AnimatedButton box_VersionBox;
        private EnhancedLabel item_VersionBoxVersion;
        private EnhancedLabel item_InjectionBoxInjection;
        private AnimatedButton box_InjectionBox;
        private AnimatedButton item_QuitBox;
        private AnimatedButton item_LaunchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDirectory;
        public System.Windows.Forms.PictureBox item_GameBanner;
        private System.Windows.Forms.ToolTip tooltipHelper;
    }
}