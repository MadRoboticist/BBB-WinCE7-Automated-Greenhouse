using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using BEAGLEBONE.ADC;
using BEAGLEBONE.GPIO;
using BEAGLEBONE.PWM;

namespace BBB_GH_test
{
    public partial class Form1 : Form
    {
        PWM pwm1;
        PWM pwm2;
        //string PWMChannelText;
        RegistryKey pwmKey1;
        RegistryKey pwmKey2;
        GPIO gpio;

        const GPIOPin Z1FANS = GPIOPin.GPIO1_16;
        const GPIOPin Z1HEAT = GPIOPin.GPIO1_17;
        const GPIOPin Z2FANS = GPIOPin.GPIO3_19;
        const GPIOPin Z2HEAT = GPIOPin.GPIO3_21;
        const int ticks2us = 11;
        int adc4 = 0;
        int adc5 = 0;
        int adc6 = 0;
        int adc3 = 0;
        float Z1h = 0;
        float Z1t = 0;
        float Z2h = 0;
        float Z2t = 0;
        bool Z1_FANS_ON = false;
        bool Z1_HEAT_ON = false;
        bool Z1_SPRI_ON = false;
        bool Z2_FANS_ON = false;
        bool Z2_HEAT_ON = false;
        bool Z2_SPRI_ON = false;
        const double H_CONVERSION = 0.024414;
        const double T_CONVERSION = 0.024414;

        ADC adc;

        public Form1()
        {
            InitializeComponent();
            this.Text += System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            
            pwmKey1 = Registry.LocalMachine.CreateSubKey("\\Drivers\\BuiltIn\\PWM1");
            pwmKey1.SetValue("DutyCycleA", 10);
            pwmKey1.SetValue("DutyCycleB", 10);
            pwmKey1.SetValue("Frequency", 50);
            pwm1 = new PWM("PWM1:");
            pwm1.DutyCycleA = 10;
            pwm1.RunPWMA = true;
            
            
            pwmKey2 = Registry.LocalMachine.CreateSubKey("\\Drivers\\BuiltIn\\PWM2");
            pwmKey2.SetValue("DutyCycleA", 10);
            pwmKey2.SetValue("DutyCycleB", 10);
            pwmKey2.SetValue("Frequency", 50);
            pwm2 = new PWM("PWM2:");
            pwm2.DutyCycleA = 10;
            pwm2.RunPWMA = true;
            
            gpio = new GPIO();
            gpio.SetDirection(Z1FANS, Direction.Output);
            gpio.SetDirection(Z1HEAT, Direction.Output);
            gpio.SetDirection(Z2FANS, Direction.Output);
            gpio.SetDirection(Z2HEAT, Direction.Output);
            gpio.ClearBit(Z1FANS);
            gpio.ClearBit(Z1HEAT);
            gpio.ClearBit(Z2FANS);
            gpio.ClearBit(Z2HEAT);

            adc = new ADC();

            updateTMR.Enabled = true;
        }
  
        private void updateTMR_Tick(object sender, EventArgs e)
        {
            adc.Scan = ADC.ADCChannel.AN4;
            adc4 = (int)adc.ReadChannel(ADC.ADCChannel.AN4);
            Z1h = (float)(adc4 * H_CONVERSION);
            Z1humidity.Text = Z1h.ToString("0.00") + "%";
            adc.Scan = ADC.ADCChannel.AN5;
            adc5 = (int)adc.ReadChannel(ADC.ADCChannel.AN5);
            Z1t = (float)(adc5 * T_CONVERSION);
            Z1temp.Text = Z1t.ToString("0.00") + "°F";
            adc.Scan = ADC.ADCChannel.AN6;
            adc6 = (int)adc.ReadChannel(ADC.ADCChannel.AN6);
            Z2h = (float)(adc6 * H_CONVERSION);
            Z2humidity.Text = Z2h.ToString("0.00") + "%";
            adc.Scan = ADC.ADCChannel.AN3;
            adc3 = (int)adc.ReadChannel(ADC.ADCChannel.AN3);
            Z2t = (float)(adc3 * T_CONVERSION);
            Z2temp.Text = Z2t.ToString("0.00") + "°F";

            if (Z1fansON.Checked)
            {
                if ((Z1_FANS_ON && (Z1t < Z1TMAX.Value)) ||
                    (!Z1_FANS_ON && (Z1t > Z1TMAX.Value)))
                {
                    ToggleZ1fans();
                }

            }
            if (Z1heatON.Checked)
            {
                if ((Z1_HEAT_ON && (Z1t > Z1TMIN.Value)) ||
                    (!Z1_HEAT_ON && (Z1t < Z1TMIN.Value)))
                {
                    ToggleZ1heat();
                }
            }
            if (Z1sprinklersON.Checked)
            {
                if ((Z1_SPRI_ON && (Z1h > Z1HMIN.Value)) ||
                    (!Z1_SPRI_ON && (Z1h < Z1HMIN.Value)))
                {
                    ToggleZ1sprinklers();
                }
            }

            if (Z2fansON.Checked)
            {
                if ((Z2_FANS_ON && (Z2t < Z2TMAX.Value)) ||
                    (!Z2_FANS_ON && (Z2t > Z2TMAX.Value)))
                {
                    ToggleZ1fans();
                }
            }
            if (Z2heatON.Checked)
            {
                if ((Z2_HEAT_ON && (Z2t > Z2TMIN.Value)) ||
                    (!Z2_HEAT_ON && (Z2t < Z2TMIN.Value)))
                {
                    ToggleZ2heat();
                }
            }
            if (Z2sprinklersON.Checked)
            {
                if ((Z2_SPRI_ON && (Z2h > Z2HMIN.Value)) ||
                    (!Z2_SPRI_ON && (Z2h < Z2HMIN.Value)))
                {
                    ToggleZ2sprinklers();
                }
            }
        }
        private void Z1TMAX_ValueChanged(object sender, EventArgs e)
        {
            Z1TMAXnum.Value = Z1TMAX.Value;
        }
        private void Z1TMAXnum_ValueChanged(object sender, EventArgs e)
        {
            Z1TMAX.Value = (int)Z1TMAXnum.Value;
        }

        private void Z1TMIN_ValueChanged(object sender, EventArgs e)
        {
            Z1TMINnum.Value = Z1TMIN.Value;
        }
        private void Z1TMINnum_ValueChanged(object sender, EventArgs e)
        {
            Z1TMIN.Value = (int)Z1TMINnum.Value;
        }

        private void Z1HMIN_ValueChanged(object sender, EventArgs e)
        {
            Z1HMINnum.Value = Z1HMIN.Value;
        }
        private void Z1HMINnum_ValueChanged(object sender, EventArgs e)
        {
            Z1HMIN.Value = (int)Z1HMINnum.Value;
        }

        private void Z2TMAX_ValueChanged(object sender, EventArgs e)
        {
            Z2TMAXnum.Value = Z2TMAX.Value;
        }
        private void Z2TMAXnum_ValueChanged(object sender, EventArgs e)
        {
            Z2TMAX.Value = (int)Z2TMAXnum.Value;
        }

        private void Z2TMIN_ValueChanged(object sender, EventArgs e)
        {
            Z2TMINnum.Value = Z2TMIN.Value;
        }
        private void Z2TMINnum_ValueChanged(object sender, EventArgs e)
        {
            Z2TMIN.Value = (int)Z2TMINnum.Value;
        }

        private void Z2HMIN_ValueChanged(object sender, EventArgs e)
        {
            Z2HMINnum.Value = Z2HMIN.Value;
        }
        private void Z2HMINnum_ValueChanged(object sender, EventArgs e)
        {
            Z2HMIN.Value = (int)Z2HMINnum.Value;
        }

        private void Z1fans_Click(object sender, EventArgs e)
        {
            Z1fansON.Checked = false;
            ToggleZ1fans();
        }
        private void ToggleZ1fans()
        {
            if (Z1_FANS_ON)
            {
                gpio.ClearBit(Z1FANS);
                Z1fans.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                gpio.SetBit(Z1FANS);
                Z1fans.BackColor = System.Drawing.Color.LightGreen;
            }
            Z1_FANS_ON = !Z1_FANS_ON;
        }
        private void Z1heat_Click(object sender, EventArgs e)
        {
            Z1heatON.Checked = false;
            ToggleZ1heat();
        }
        private void ToggleZ1heat()
        {
            if (Z1_HEAT_ON)
            {
                gpio.ClearBit(Z1HEAT);
                Z1heat.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                gpio.SetBit(Z1HEAT);
                Z1heat.BackColor = System.Drawing.Color.LightGreen;
            }
            Z1_HEAT_ON = !Z1_HEAT_ON;
        }
        private void Z1sprinklers_Click(object sender, EventArgs e)
        {
            Z1sprinklersON.Checked = false;
            ToggleZ1sprinklers();
        }
        private void ToggleZ1sprinklers()
        {
            if (pwm1.DutyCycleA == 10)
            {
                pwm1.DutyCycleA = 5;
                Z1sprinklers.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                pwm1.DutyCycleA = 10;
                Z1sprinklers.BackColor = System.Drawing.Color.LightCoral;
            }
            Z1_SPRI_ON = !Z1_SPRI_ON;
        }
        private void Z2fans_Click(object sender, EventArgs e)
        {
            Z2fansON.Checked = false;
            ToggleZ2fans();
        }
        private void ToggleZ2fans()
        {
            if (Z2_FANS_ON)
            {
                gpio.ClearBit(Z2FANS);
                Z2fans.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                gpio.SetBit(Z2FANS);
                Z2fans.BackColor = System.Drawing.Color.LightGreen;
            }
            Z2_FANS_ON = !Z2_FANS_ON;
        }
        private void Z2heat_Click(object sender, EventArgs e)
        {
            Z2heatON.Checked = false;
            ToggleZ2heat();
        }
        private void ToggleZ2heat()
        {
            if (Z2_HEAT_ON)
            {
                gpio.ClearBit(Z2HEAT);
                Z2heat.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                gpio.SetBit(Z2HEAT);
                Z2heat.BackColor = System.Drawing.Color.LightGreen;
            }
            Z2_HEAT_ON = !Z2_HEAT_ON;
        }
        private void Z2sprinklers_Click(object sender, EventArgs e)
        {
            Z2sprinklersON.Checked = false;
            ToggleZ2sprinklers();

        }
        private void ToggleZ2sprinklers()
        {
            if (pwm2.DutyCycleA == 10)
            {
                pwm2.DutyCycleA = 5;
                Z2sprinklers.BackColor = System.Drawing.Color.LightGreen;

            }
            else
            {
                pwm2.DutyCycleA = 10;
                Z2sprinklers.BackColor = System.Drawing.Color.LightCoral;
            }
            Z2_SPRI_ON = !Z2_SPRI_ON;
        }
        
    }      
}